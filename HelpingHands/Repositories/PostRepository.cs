using HelpingHands.Entities;
using HelpingHands.Repositories.Contracts;
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
            return await _dbContext.Posts.ToListAsync();
        }
    }
}
