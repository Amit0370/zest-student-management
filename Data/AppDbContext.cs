using Microsoft.EntityFrameworkCore;
using ZestStudentAPI.Models;

namespace ZestStudentAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}