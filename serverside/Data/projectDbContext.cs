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
    }
}
