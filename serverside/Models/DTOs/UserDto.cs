namespace serverside.Models.DTOs
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public int ReputationPoints { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
