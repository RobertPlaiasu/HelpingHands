using AutoMapper;
using HelpingHands.Dtos;
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
        private readonly IOngRepository _ongRepository;
        private readonly IMapper _mapper;

        public PostService(IPostRepository postRepository,INeedRepository needRepository,ICategoryRepository categoryRepository,IMapper mapper,
            IOngRepository ongRepository)
        {
            _postRepository = postRepository;
            _needRepository = needRepository;
            _categoryRepository = categoryRepository;
            _ongRepository = ongRepository;
            _mapper = mapper;
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

        
        public async Task<Response<string>> CreatePost(CreatePostDto post)
        {
            if (null == await _ongRepository.GetOngById(post.OngId))
                return new Response<string>(StatusCodes.Status400BadRequest,"Ong-ul nu exista in baza de date!");
              return await _postRepository.CreatePost(_mapper.Map<Post>(post));

              
        }
    }
}
