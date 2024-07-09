using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DotNet7.PullrequestTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetBlog()
        {
            return Ok("This is testing");
        }
        [HttpGet]
        public async Task<IActionResult> GetBlogs()
        {
            return Ok("This is testing");
        }
    }
}
