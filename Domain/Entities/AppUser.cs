using Microsoft.AspNetCore.Identity;
using System.Data;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string Mobile { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }

        
    }

    public enum Role
    {
        Admin,
        Customer
    }
}