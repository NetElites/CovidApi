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
    public class HospitalController : ControllerBase
    {
        private readonly HospitalRepository _hospital;
        public HospitalController(HospitalRepository hospital)
        {
            _hospital = hospital;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = _hospital.GetHospital();
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
