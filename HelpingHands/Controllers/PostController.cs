using HelpingHands.Dtos;
using HelpingHands.Services;
using HelpingHands.Services.Contracts;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelpingHands.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowSpecificOrigins")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("posts")]
        public async Task<ActionResult<IEnumerable<object>>> GetPosts()
        {
            var response = await _postService.GetPosts();
            return StatusCode(response.StatusCode, new
            {
                Message = response.Message,
                Data = response.Data
            });
        }
        [HttpGet("create")]
        public async Task<ActionResult<object>> GetCreatePost()
        {
            var response = await _postService.GetCategories();
            return StatusCode(response.StatusCode, new
            {
                Message = response.Message,
                Data = response.Data
            });
        }
        [HttpGet("counties")]
        public async Task<ActionResult<IEnumerable<string>>> GetCounties()
        {
            return Ok(new List<string>  {
                "Bucureşti",
                "Alba",
                "Botoşani",
                "Braşov"
            });
            
        }

        [HttpPost("store")]
        public async Task<ActionResult<string>> StorePost(CreatePostDto post)
        {
            var response = await _postService.CreatePost(post);
            return StatusCode(response.StatusCode, new
            {
                Message = response.Message,
                Data = response.Data
            });
        }

    }
}
