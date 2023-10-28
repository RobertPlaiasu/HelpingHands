using HelpingHands.Entities;
using HelpingHands.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

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
        public async Task<IEnumerable<Need>> GetNeeds()
        {
            return await _dbContext.Needs.ToListAsync();
        }

        public async Task<string> CreateNeed(Need need)
        {
            await _dbContext.Needs.AddAsync(need);
            await _dbContext.SaveChangesAsync();
            return  "Need a fost creat cu succes!";
        }
    }
}
