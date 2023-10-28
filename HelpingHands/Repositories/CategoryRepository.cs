using HelpingHands.Entities;
using HelpingHands.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace HelpingHands.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly HelpingHandsDbContext _dbContext;
        public CategoryRepository(HelpingHandsDbContext context)
        {
            _dbContext = context;
        }
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _dbContext.Categories.ToListAsync();
        }
    }
}
