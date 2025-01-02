using Microsoft.Extensions.Hosting;

namespace serverside.Models.Domain
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int ReputationPoints { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation properties
       // public ICollection<Post> Posts { get; set; }
        // public ICollection<Comment> Comments { get; set; }
    }

}
