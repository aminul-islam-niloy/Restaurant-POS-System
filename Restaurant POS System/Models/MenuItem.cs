using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant_POS_System.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        [Display(Name = "Quantity Type")]
        public QuantityType QuantityType { get; set; }
        public DateTime AdditionTime { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountPrice { get; set; }

    }
    public enum QuantityType
    {
        Item,
        Kg,
        Liter,
    }
}
