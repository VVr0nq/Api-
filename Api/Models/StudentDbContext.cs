using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Api.Models
{
    public class StudentDbContext : IdentityDbContext<UserEntity, UserRole, int>
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; } = null;

    }
}
