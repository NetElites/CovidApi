using CovidApi.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApi.Application.Repository
{
    public interface VaccineRepository
    {
        Task<AddVaccineDto> PostVaccine(AddVaccineDto addVaccine);
        Task<List<VaccineDto>> GetVaccine();
    }
}
