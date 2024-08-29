using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SimpleOnlineStore.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "Code")]
        [Column(TypeName = "int")]
        public int ID { get; set; }

        [Display(Name = "Name")]
        [Column(TypeName = "nvarchar(max)")]
        public string? Name { get; set; }

        [Display(Name = "Description")]
        [Column(TypeName = "nvarchar(max)")]
        public string? Description { get; set; }

        [Display(Name = "Price")]
        [Column(TypeName = "float")]
        public float Price { get; set; }

        [Display(Name = "Stock Quantity")]
        [Column(TypeName = "nvarchar(max)")]
        public string? StockQuantity { get; set; }

        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }
        public Category? Category { get; set; }


    }
}
