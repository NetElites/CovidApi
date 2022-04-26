using CovidApi.Application.Dto;
using CovidApi.Application.Repository;
using CovidApi.Domain.VaccineModel;
using CovidApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApi.Application.Services
{
    public class VaccineServices : VaccineRepository
    {
        private readonly ApplicationDbContext _context;
        public VaccineServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<VaccineDto>> GetVaccine()
        {
            var result = _context.vaccines.Select(vaccine => new VaccineDto
            {
                VaccineId=vaccine.VaccineId,
                UserName=vaccine.UserName,
                Age=vaccine.Age,
                TypeVaccine=vaccine.TypeVaccine
            }).ToList();
            return result;
        }

        public async Task<AddVaccineDto> PostVaccine(AddVaccineDto addVaccine)
        {
            Vaccine newVaccine = new Vaccine
            {
                UserName=addVaccine.vaccineDto.UserName,
                Age=addVaccine.vaccineDto.Age,
                TypeVaccine=addVaccine.vaccineDto.TypeVaccine
            };
            await _context.vaccines.AddAsync(newVaccine);
            await _context.SaveChangesAsync();
            return new AddVaccineDto
            {
                vaccineDto = new VaccineDto
                {
                    UserName=addVaccine.vaccineDto.UserName,
                    Age=addVaccine.vaccineDto.Age,
                    TypeVaccine=addVaccine.vaccineDto.TypeVaccine
                }
            };
        }
    }
}
