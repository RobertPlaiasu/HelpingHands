using HelpingHands.Entities;

namespace HelpingHands.Repositories.Contracts
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetAllPosts();
    }
}
