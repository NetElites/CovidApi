using CovidApi.Application.Dto;
using CovidApi.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidApi.Persistence.Context;
using CovidApi.Domain.SilderModel;

namespace CovidApi.Application.Services
{
    public class SilderServices : SilderRepository
    {
        private readonly ApplicationDbContext _context;
        public SilderServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<SilderDto>> GetSilder()
        {
            var result = _context.silderModels.Select(silder=>new SilderDto 
            {
                SilderId=silder.SilderId,
                Text= silder.Text,
                UrlImage= silder.UrlImage
            }).ToList();
            return result;
        }
    }
}
