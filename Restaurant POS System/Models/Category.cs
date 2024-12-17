using System.ComponentModel.DataAnnotations;

namespace Restaurant_POS_System.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [Display(Name = "Menu Type")]
        public string CategoryName { get; set; }

        
    }
}
