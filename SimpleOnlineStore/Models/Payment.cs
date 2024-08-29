using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SimpleOnlineStore.Models
{
    public class Payment
    {
        [Key]
        [Display(Name = "Code")]
        [Column(TypeName = "int")]
        public int ID { get; set; }

        [ForeignKey("OrderID")]
        public int OrderID { get; set; }
        public Order? Order { get; set; }

        [Display(Name = "Payment Method")]
        [Column(TypeName = "nvarchar(max)")]
        public string? PaymentMethod { get; set; }

        [Display(Name = "Payment Status")]
        [Column(TypeName = "nvarchar(max)")]
        public string? PaymentStatus { get; set; }

        [Display(Name = "Amount")]
        [Column(TypeName = "float")]
        public float Amount { get; set; }

        [Display(Name = "Payment Date")]
        [Column(TypeName = "nvarchar(max)")]
        public string? PaymentDate { get; set; }
    }
}
