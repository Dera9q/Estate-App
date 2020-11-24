using System.Net.Mime;
using EstateWeb.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EstateApp.Data.DatabaseContext.AuthentificationDbContext
{
    public class AuthentificationDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthentificationDbContext(DbContextOptions<AuthentificationDbContext>options) : base(options)
           {

           }
    }
}