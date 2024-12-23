
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreRepositorywithEF.Models
{
    public class Tutorial
    {
        public int Id { get; set; }

        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name can only contain alphabets and spaces.")]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public List<Article> Articles { get; set; }
        
    }
}
