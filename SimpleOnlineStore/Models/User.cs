using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace SimpleOnlineStore.Models
{
    public class User
    {
        [Key]
        [Display(Name = "Code")]
        [Column(TypeName = "int")]
        public int ID { get; set; }

        [Display(Name = "User Name")]
        [Column(TypeName = "nvarchar(max)")]
        public string? UserName { get; set; }

        [Display(Name = "Password")]
        [Column(TypeName = "nvarchar(max)")]
        public string? Password { get; set; }

        [Display(Name = "Email")]
        [Column(TypeName = "nvarchar(max)")]
        public string? Email { get; set; }

        [Display(Name = "Phone Number")]
        [Column(TypeName = "int")]
        public int PhoneNumber { get; set; }

        [Display(Name = "Address")]
        [Column(TypeName = "nvarchar(max)")]
        public string? Address { get; set; }
    }
}
