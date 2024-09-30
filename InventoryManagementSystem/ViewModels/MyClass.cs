using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.ViewModels
{
    public class MyClass
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; } = null!;
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int SKUCode { get; set; }
        [Required]
        public System.DateTime EntryDate { get; set; }
        public string PicturePath { get; set; } = null!;
        public bool InStock { get; set; }
    }
}
