using Microsoft.EntityFrameworkCore;
using TaskManager.Models; // This must match the namespace of User
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TaskManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } // User class should be found here
        public DbSet<TaskItem> Tasks { get; set; }
    }
}
