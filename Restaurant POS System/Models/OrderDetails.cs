using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restaurant_POS_System.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        [Display(Name = "Order")]

        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [Display(Name = "Product")]
        public int MenuItemId { get; set; }

        [ForeignKey("MenuItemId")]
        public MenuItem MenuItem { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public PaymentCondition PaymentCondition { get; set; }
        public PaymentMethods PaymentMethods { get; set; }
    }
        public enum PaymentCondition
        {
            Paid,
            UnPaid
        }

        public enum PaymentMethods
        {
            Cash,
            Card
        }
}
