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
    public class VaccineController : ControllerBase
    {
        private readonly VaccineRepository _vaccine;
        public VaccineController(VaccineRepository vaccine)
        {
            _vaccine = vaccine;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = _vaccine.GetVaccine();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post(ItemVaccine item)
        {
            if (ModelState.IsValid)
            {
                var result = _vaccine.PostVaccine(new AddVaccineDto 
                {
                    vaccineDto=new VaccineDto
                    {
                        UserName=item.UserName,
                        Age=item.Age,
                        TypeVaccine=item.TypeVaccine
                    }
                });
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
