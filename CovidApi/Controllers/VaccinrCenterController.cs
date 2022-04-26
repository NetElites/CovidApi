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
    public class VaccinrCenterController : ControllerBase
    {
        private readonly VaccinrCenterRepository _vaccinr;
        public VaccinrCenterController(VaccinrCenterRepository vaccinr)
        {
            _vaccinr = vaccinr;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = _vaccinr.GetVaccinrCenter();
            return Ok(new ResponseDto 
            {
                IsSccees=true,
                DisplayMessage="عملیات با موفقیت انجام شد",
                Result=result,
                linksDtos=new List<LinksDto>()
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
