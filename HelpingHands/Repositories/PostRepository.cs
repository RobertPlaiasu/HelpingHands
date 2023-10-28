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

        public async Task<Response<int>> CreatePost(Post post)
        {
            await _dbContext.Posts.AddAsync(post);
            await _dbContext.SaveChangesAsync();
            return new Response<int>(StatusCodes.Status201Created,"Postare a fost creata cu succes!",post.Id);
        }
         

        public async Task DeletePost(Post post)
        {
            _dbContext.Posts.Remove(post);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Post> GetPostById(int id)
        {
            return await _dbContext.Posts.FindAsync(id);
        }
    }
}
