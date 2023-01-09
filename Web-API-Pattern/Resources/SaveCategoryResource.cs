using System.ComponentModel.DataAnnotations;

namespace Web_API_Pattern.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}