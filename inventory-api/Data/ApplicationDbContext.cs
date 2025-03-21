// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using inventory_api.Models;

namespace inventory_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set unique constraint on Email
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
                
            base.OnModelCreating(modelBuilder);
        }
    }
}