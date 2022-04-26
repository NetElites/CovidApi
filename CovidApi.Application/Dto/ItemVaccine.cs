using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApi.Application.Dto
{
    public class ItemVaccine
    {
        [Display(Name = "نام کاربر")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی است")]
        [MinLength(2, ErrorMessage = "{0} باید حداقل {1} کاراکتر باشد")]
        [MaxLength(30, ErrorMessage = "{0} باید حداقل {1} کاراکتر باشد")]
        public string UserName { get; set; }
        [Display(Name = "سن کاربر")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی است")]
        [MinLength(2, ErrorMessage = "{0} باید حداقل {1} کاراکتر باشد")]
        [MaxLength(2, ErrorMessage = "{0} باید حداقل {1} کاراکتر باشد")]
        public string Age { get; set; }
        [Display(Name = "نوع واکسن")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی است")]
        public string TypeVaccine { get; set; }
    }
}
