using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApi.Application.Dto
{
    public class SilderDto
    {
        [Key]
        public int SilderId { get; set; }
        [Display(Name = "نوشته اسلایدر")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی است")]
        public string Text { get; set; }
        [Display(Name = "عکس اسلایدر")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی است")]
        public string UrlImage { get; set; }
    }
}
