using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApi.Application.Dto
{
    public class ArticleDto
    {
        [Key]
        public int ArticleId { get; set; }
        [Display(Name = "عکس مقاله")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی است")]
        public string UrlImage { get; set; }
        [Display(Name = "عنوان مقاله")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی است")]
        public string Title { get; set; }
        [Display(Name = "متن مقاله")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی است")]
        public string Text { get; set; }
        [Display(Name = "نام نویسنده")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی است")]
        public string NameAuthor { get; set; }
    }
}
