using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleAPI.Models;

namespace SimpleAPI.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) 
        { 
        }

        public DbSet<Product> Products { get; set; }
    }
}
