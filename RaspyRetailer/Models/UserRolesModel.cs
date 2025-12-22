using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace RaspyRetailer.Models
{
    public class UserRolesModel:IdentityRole
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserRole { get; set; }
        
    }
}
