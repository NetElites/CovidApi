using CovidApi.Application.Dto;
using CovidApi.Application.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly ArticleRepository _article;
        public ArticleController(ArticleRepository article)
        {
            _article = article;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = _article.GetArticle();
            return Ok(new ResponseDto
            {
                IsSccees = true,
                DisplayMessage = "عملیات با موفقیت انجام شد",
                Result = result,
                linksDtos = new List<LinksDto>
                {
                    new LinksDto
                    {
                        Href="",
                        Method="GET",
                        Rel="GETALL"
                    }
                }
            });
        }
    }
}
