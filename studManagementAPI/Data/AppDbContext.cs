using studManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace studManagementAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
