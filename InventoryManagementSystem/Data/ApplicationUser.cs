using Microsoft.AspNetCore.Identity;

namespace InventoryManagementSystem.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = null!;
        public string CellPhone { get; set; } = null!;
        public string Country { get; set; } = null!;
    }
}
