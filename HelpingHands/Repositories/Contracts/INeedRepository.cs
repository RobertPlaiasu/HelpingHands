using HelpingHands.Entities;

namespace HelpingHands.Repositories.Contracts
{
    public interface INeedRepository
    {
        Task<IEnumerable<Need>> GetNeedsForPost(int postId);
    }
}
