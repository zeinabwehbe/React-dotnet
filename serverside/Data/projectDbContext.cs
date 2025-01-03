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

        //// DbSets for each entity
        //public DbSet<Users> Users { get; set; }
        public DbSet<Posts> Posts { get; set; }
        //public DbSet<Tags> Tags { get; set; }
        //public DbSet<PostTags> PostTags { get; set; }
        //public DbSet<Categories> Categories { get; set; }
        //public DbSet<Votes> Votes { get; set; }
        //public DbSet<Notifications> Notifications { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure Users
            modelBuilder.Entity<Users>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Users>()
                .HasMany(u => u.Posts)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            // Configure Posts
            modelBuilder.Entity<Posts>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Posts>()
                .HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserId);
        }
    }
}