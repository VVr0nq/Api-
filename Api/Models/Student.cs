using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace Api.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }

        public string? Password { get; set; }
    }
    public class UserEntity : IdentityUser<int>
    {
    }
    public class UserRole : IdentityRole<int>
    {
    }
}
