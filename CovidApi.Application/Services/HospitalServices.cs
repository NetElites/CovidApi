using CovidApi.Application.Dto;
using CovidApi.Application.Repository;
using CovidApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApi.Application.Services
{
    public class HospitalServices : HospitalRepository
    {
        private readonly ApplicationDbContext _context;
        public HospitalServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<HospitalDto>> GetHospital()
        {
            var result = _context.Hospitals.Select(hospital => new HospitalDto
            {
                HospitalId=hospital.HospitalId,
                Title=hospital.Title,
                Location=hospital.Location,
                UrlImage=hospital.UrlImage
            }).ToList();
            return result;
        }
    }
}
