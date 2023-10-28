using HelpingHands.Entities;

namespace HelpingHands.Repositories.Contracts
{
    public interface INeedRepository
    {
        Task<List<Need>> GetNeedsForPost(int postId);
    }
}
