using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using library.Models;

namespace library.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<library.Models.Student> Student { get; set; } = default!;
        public DbSet<library.Models.Teacher> Teacher { get; set; } = default!;
    }
}
