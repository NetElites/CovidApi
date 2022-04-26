using CovidApi.Application.Dto;
using CovidApi.Domain.SilderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApi.Application.Repository
{
    public interface SilderRepository
    {
        Task<List<SilderDto>> GetSilder();
    }
}
