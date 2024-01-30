using AspNetCoreDemo.Models;

namespace AspNetCoreDemo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserProfile> UserProfiles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("UserDatabase");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            // Seed mock data
            /* modelBuilder.Entity<UserProfile>().HasData(
                MockData.UserProfiles.ToArray()
            ); */
            modelBuilder.Entity<UserProfile>().HasData(
            new UserProfile
            {
                Id = 1,
                Name = "John Doe",
                Email = "john.doe@example.com",
                ProfilePicture = "https://example.com/profiles/john_doe.jpg",
                Bio = "Software Engineer",
                Password = "password123"
            },
            new UserProfile
            {
                Id = 2,
                Name = "Jane Smith",
                Email = "jane.smith@example.com",
                ProfilePicture = "https://example.com/profiles/jane_smith.jpg",
                Bio = "Graphic Designer",
                Password = "password456"
            }
        );
        }
    }
}
