using HelpingHands.Entities;

namespace HelpingHands.Repositories.Contracts
{
    public interface INeedRepository
    {
        Task<List<Need>> GetNeedsForPost(int postId);
        Task<IEnumerable<Need>> GetNeeds();
        Task<string> CreateNeed(Need need);
    }
}
