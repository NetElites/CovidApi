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
    public class VaccinrCenterServices : VaccinrCenterRepository
    {
        private readonly ApplicationDbContext _context;
        public VaccinrCenterServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<VaccinrCenterDto>> GetVaccinrCenter()
        {
            var result = _context.vaccinrCenters.Select(vaccinrCenter => new VaccinrCenterDto
            {
                VaccinrCenterId=vaccinrCenter.VaccinrCenterId,
                Title=vaccinrCenter.Title,
                Location=vaccinrCenter.Location,
                UrlImage=vaccinrCenter.UrlImage
            }).ToList();
            return result;
        }
    }
}
