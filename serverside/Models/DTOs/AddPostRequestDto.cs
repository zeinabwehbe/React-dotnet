namespace serverside.Models.DTOs
{
    public class AddPostRequestDto
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //public int CategoryId { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
    }
}
