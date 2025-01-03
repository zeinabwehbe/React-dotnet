using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using serverside.Data;
using serverside.Models.Domain;
using serverside.Models.DTOs;
using serverside.Repository;

namespace serverside.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        // this is to initialize them
        private readonly projectDbContext dbContext;
        private readonly IPostRepository postRepository;
        private readonly IMapper mapper;
        private readonly ILogger<PostsController> _logger;


        public PostsController(projectDbContext projectDbContext, IPostRepository postRepository, IMapper mapper, ILogger<PostsController> logger)
        {
            this.postRepository = postRepository;
            this.dbContext = projectDbContext;
            this.mapper = mapper;
            _logger = logger;


        }

        // GET ALL Posts
        // https://localhost:7069/api/Posts
        //GET: /api/walks?filerOn=MyProperty&filterQuery=Track
        [HttpGet]
        //public async Task<IActionResult> GetAllPosts([FromQuery] string filterOn, [FromQuery] int? filterQuery )
        public async Task<IActionResult> GetAllPosts()
        {
            try
            {
                // Get data from the database - Domain Model
                var postsDomain = await postRepository.GetAllPostsAsync();

                // Map Domain Models to DTOs
                var postsDto = mapper.Map<List<PostDto>>(postsDomain);

                // Return DTOs
                return Ok(postsDto);
            }
            catch (Exception ex)
            {
                // Log the error
                _logger.LogError(ex, "An error occurred while retrieving posts.");
                Console.WriteLine(ex);
                // Return a 500 Internal Server Error response
                return StatusCode(500, "An error occurred while retrieving posts.");
            }
        }

        // POST to create new user
        // POST: https://localhost:7069/api/
        // POST to create new user
        // POST: https://localhost:7069/api/Posts
        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] AddPostRequestDto addPostRequestDto)
        {
            // Map DTO to domain model
            var postDomainModel = mapper.Map<Posts>(addPostRequestDto);

            // Use domain model to create user
            postDomainModel = await postRepository.CreateAsync(postDomainModel);

            // Map Domain Models to DTOs
            var postDto = mapper.Map<PostDto>(postDomainModel);

            //return CreatedAtAction(nameof(GetUserById), new { id = userDomainModel.Id }, userDto);
            return Ok(postDto);
        }


    }
}
