using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SimpleOnlineStore.Models
{
    public class Order
    {
        [Key]
        [Display(Name = "Code")]
        [Column(TypeName = "int")]
        public int ID { get; set; }

        [Display(Name = "Total Price")]
        [Column(TypeName = "float")]
        public float TotalPrice { get; set; }

        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public User? User { get; set; }  

        [Display(Name = "Order Status")]
        [Column(TypeName = "nvarchar(max)")]
        public string? OrderStatus { get; set; }
    }
}
