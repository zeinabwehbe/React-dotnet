using serverside.Models.Domain;

namespace serverside.Repository
{
    public interface IPostRepository
    {
        Task<List<Posts>> GetAllPostsAsync();
        Task<Posts> CreateAsync(Posts post);

    }
}
