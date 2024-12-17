namespace Restaurant_POS_System.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int StockLevel { get; set; }

        // Navigation property
        public int MenuItemId { get; set; } 
        public MenuItem MenuItem { get; set; }
    }
}
