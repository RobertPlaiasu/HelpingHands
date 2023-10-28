using HelpingHands.Entities;
using HelpingHands.Repositories.Contracts;
using HelpingHands.Responses;
using HelpingHands.Services.Contracts;
using Microsoft.Extensions.Hosting;

namespace HelpingHands.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly INeedRepository _needRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PostService(IPostRepository postRepository,INeedRepository needRepository,ICategoryRepository categoryRepository)
        {
            _postRepository = postRepository;
            _needRepository = needRepository;
            _categoryRepository = categoryRepository;
        }
        public async Task<Response<IEnumerable<Post>>> GetPosts()
        {
            var posts = await _postRepository.GetAllPosts();
            
            return new Response<IEnumerable<Post>>(StatusCodes.Status200OK, "Postarile au fost transmise cu succes.", posts);

        }

        public async Task<Response<IEnumerable<Category>>> GetCategories()
        {
            return new Response<IEnumerable<Category>>(StatusCodes.Status200OK, 
                "Listele au fost transmise cu succes.",
                await _categoryRepository.GetCategories());
        }

        
        public async Task<Response<string>> CreatePost(Post post)
        {
            throw new Exception("t");
        }
    }
}
