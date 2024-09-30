using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.ViewModels
{
    public class OrderVM
    {
        public OrderVM()
        {
            this.OrderDetails = new List<OrderDetailVM>();
        }
        public Order Order { get; set; } = null!;
        public List<OrderDetailVM> OrderDetails { get; set; } = null!;
    }
}
