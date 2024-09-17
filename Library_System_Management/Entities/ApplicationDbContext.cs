using Microsoft.EntityFrameworkCore;
using Library_System_Management.Models;
using Library_System_Management.Entities;

namespace Library_System_Management.Entities
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=PANDA;Initial Catalog=Library_Management;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        public DbSet<User> users { get; set; }
        public DbSet<Library_System_Management.Models.LoginModel> LoginModel { get; set; } = default!;
        public DbSet<Library_System_Management.Entities.RegisterUser> RegisterUser { get; set; } = default!;

    }

}
