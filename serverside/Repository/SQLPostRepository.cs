using Microsoft.EntityFrameworkCore;
using serverside.Data;
using serverside.Models.Domain;

namespace serverside.Repository
{
    public class SQLPostRepository : IPostRepository
    {
        private readonly projectDbContext _projectDbContext;

        public SQLPostRepository(projectDbContext projectDbContext)
        {
            this._projectDbContext = projectDbContext;
        }
        public async Task<Posts> CreateAsync(Posts post)
        {
            // Check if the unique field already exists
            await _projectDbContext.Posts.AddAsync(post);
            await _projectDbContext.SaveChangesAsync();
            return post;
        }

        public async Task<List<Posts>> GetAllPostsAsync()
        {
            IQueryable<Posts> postsQuery = _projectDbContext.Posts;

            //// filtering
            //if (!string.IsNullOrWhiteSpace(filterOn))
            //{
            //    if (filterOn.Equals("MyProperty", StringComparison.OrdinalIgnoreCase))
            //    {
            //        usersQuery = usersQuery.Where(x => x.MyProperty == filterQuery);
            //    }
            //}

            var posts = await postsQuery.ToListAsync();
            return posts;
        }
    }
    }
