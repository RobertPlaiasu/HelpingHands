using HelpingHands.Entities;
using HelpingHands.Repositories.Contracts;
using HelpingHands.Responses;
using Microsoft.EntityFrameworkCore;

namespace HelpingHands.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly HelpingHandsDbContext _dbContext;

        public PostRepository(HelpingHandsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            return await _dbContext.Posts.Include(x=>x.Needs).ToListAsync();
        }

        public async Task<Response<string>> CreatePost(Post post)
        {
            await _dbContext.Posts.AddAsync(post);
            await _dbContext.SaveChangesAsync();
            return new Response<string>(StatusCodes.Status201Created,"Postare a fost creata cu succes!");
        }

         
    }
}
