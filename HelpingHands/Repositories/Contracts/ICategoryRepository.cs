using HelpingHands.Entities;

namespace HelpingHands.Repositories.Contracts
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}
