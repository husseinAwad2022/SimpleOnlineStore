using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SimpleOnlineStore.Models
{
    public class Cart
    {
        [Key]
        [Display(Name = "Code")]
        [Column(TypeName = "int")]
        public int ID { get; set; }

        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public User? User { get; set; }

        [Display(Name = "Cart Number")]
        [Column(TypeName = "int")]
        public int CartNumber { get; set; }
    }
}
