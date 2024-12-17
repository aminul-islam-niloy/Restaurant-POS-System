namespace Restaurant_POS_System.Models
{
    public class Table
    {
        public int TableId { get; set; }
        public int TableNumber { get; set; }
        public string Status { get; set; } 

        public string StaffUserId { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
