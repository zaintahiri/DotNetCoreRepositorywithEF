using DotNetCoreRepositorywithEF.Models;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreRepositorywithEF.ViewModels
{
    public class AritcleViewModel
    {
        public AritcleViewModel()
        { 
            Tutorials = new List<Tutorial>();
        }
        public int ArticleId { get; set; }

        [Required(ErrorMessage = "Please Enter Title")]
        [Display(Name ="Please enter article title ")]
        public string ArticleTitle { get; set; }

        [Required(ErrorMessage = "Please Enter Article Content")]
        [Display(Name = "Write Content")]
        public string ArticleContent { get; set; }

        public int TutorialId { get; set; }

        public List<Tutorial> Tutorials { get; set; }
    }
}
