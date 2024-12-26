using Microsoft.AspNetCore.Mvc;

namespace serverside.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //GET: https"//localhost:portnumber/api/users
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            string[] userNames = new string[] { "John", "Jane", "Mark" };
            return Ok(userNames);
        }
    }
}
