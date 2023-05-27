using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    FullName = "John Doe",
                    Email = "john@test.com",
                    UserName = "john@test.com",
                    Mobile = "999999999"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");

            }
        }
    }
}
