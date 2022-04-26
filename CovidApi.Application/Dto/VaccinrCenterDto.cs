using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApi.Application.Dto
{
    public class VaccinrCenterDto
    {
        [Key]
        public int VaccinrCenterId { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی است")]
        public string Title { get; set; }
        [Display(Name = "محل قرارگیری")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی است")]
        public string Location { get; set; }
        [Display(Name = "عکس")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی است")]
        public string UrlImage { get; set; }
    }
}
