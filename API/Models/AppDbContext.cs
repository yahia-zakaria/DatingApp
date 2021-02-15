using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class AppDbContext :DbContext 
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<AppUser> Users { get; set; }         
    }
}