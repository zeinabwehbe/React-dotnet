using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using serverside.Models.Domain;

namespace serverside.Data
{
    public class projectDbContext : DbContext
    {
        public projectDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) //pass it to the base
        {

        }

        //create the props according to the tables in db

        public DbSet<Users> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>().HasData(
                new Users
                {
                    Id = 5,
                    Username = "UserFive",
                    Email = "user5@example.com",
                    Password = HashPassword("password5"), // Replace with a hashed password
                    Role = "Member",
                    ReputationPoints = 6666,
                    CreatedAt = DateTime.UtcNow
                },
                new Users
                {
                    Id = 7,
                    Username = "UserSeven",
                    Email = "user7@example.com",
                    Password = HashPassword("password7"), // Replace with a hashed password
                    Role = "Admin",
                    ReputationPoints = 8888,
                    CreatedAt = DateTime.UtcNow
                }
            );
        }

        private string HashPassword(string password)
        {
            // Replace with actual hashing logic
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
