using System.ComponentModel.DataAnnotations;

namespace DotNetCoreRepositorywithEF.Models
{
    public class Article
    {
       public int ArticleId { get; set; }

        [Required(ErrorMessage ="Please Enter Title")]
        public string ArticleTitle { get; set; }

        [Required(ErrorMessage = "Please Enter Article Content")]
        public string ArticleContent { get; set; }

        public int TutorialId { get; set; }

        public Tutorial Tutorial { get; set; }

    }
}
