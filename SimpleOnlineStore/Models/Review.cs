using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SimpleOnlineStore.Models
{
    public class Review
    {
        [Key]
        [Display(Name = "Code")]
        [Column(TypeName = "int")]
        public int ID { get; set; }

        [ForeignKey("ProductID")]
        public int ProductID { get; set; }
        public Product? Product { get; set; }

        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public User? User { get; set; }

        [Display(Name = "Rating")]
        [Column(TypeName = "nvarchar(max)")]
        public string? Rating { get; set; }

        [Display(Name = "Comment")]
        [Column(TypeName = "nvarchar(max)")]
        public string? Comment { get; set; }
    }
}
