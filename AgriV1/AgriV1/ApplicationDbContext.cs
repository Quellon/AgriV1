using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AgriV1.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using AgriV1.Models;

namespace AgriV1.Data
{
    public class ApplicationDbContext : IdentityDbContext<AgriV1User, IdentityRole,String>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        // Add your own DbSets here, e.g.
        //public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Additional config...
        }
    }
}

