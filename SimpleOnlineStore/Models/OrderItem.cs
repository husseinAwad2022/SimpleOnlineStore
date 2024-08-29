using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SimpleOnlineStore.Models
{
    public class OrderItem
    {
        [Key]
        [Display(Name = "Code")]
        [Column(TypeName = "int")]
        public int ID { get; set; }

        [ForeignKey("OrderID")]
        public int OrderID { get; set; }
        public Order? Order { get; set; }

        [ForeignKey("ProductID")]
        public int ProductID { get; set; }
        public Product? Product { get; set; }

        [Display(Name = "Quantity")]
        [Column(TypeName = "nvarchar(max)")]
        public string? Quantity { get; set; }

        [Display(Name = "Price")]
        [Column(TypeName = "float")]
        public float Price { get; set; }
    }
}
