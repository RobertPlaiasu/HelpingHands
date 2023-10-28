using HelpingHands.Entities;
using HelpingHands.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace HelpingHands.Repositories
{
    public class NeedRepository : INeedRepository
    {
        private readonly HelpingHandsDbContext _dbContext;

        public NeedRepository(HelpingHandsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Need>> GetNeedsForPost(int postId)
        {
            return await _dbContext.Needs.Where(x => x.PostId == postId).ToListAsync();
        }
    }
}
