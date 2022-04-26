using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApi.Application.Dto
{
    public class ResponseDto
    {
        public bool IsSccees { get; set; } = true;
        public string DisplayMessage { get; set; } = "";
        public object Result { get; set; }
        public string ErrorMessage { get; set; }
        public List<LinksDto> linksDtos { get; set; }
    }
}
