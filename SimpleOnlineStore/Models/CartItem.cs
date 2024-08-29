using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SimpleOnlineStore.Models
{
    public class CartItem
    {
        [Key]
        [Display(Name = "Code")]
        [Column(TypeName = "int")]
        public int ID { get; set; }

        [ForeignKey("CartID")]
        public int CartID { get; set; }
        public Cart? Cart { get; set; }

        [ForeignKey("ProductID")]
        public int ProductID { get; set; }
        public Product? Product { get; set; }

        [Display(Name = "Quantity")]
        [Column(TypeName = "nvarchar(max)")]
        public float Quantity { get; set; }
    }
}
