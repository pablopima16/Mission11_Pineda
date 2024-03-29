using Microsoft.EntityFrameworkCore;

namespace TheWaterProject.Models
{
    public class WaterProjectContext : DbContext
    {
        public WaterProjectContext (DbContextOptions<WaterProjectContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; } //Projects will be the name Database after migrating 
    }
}
