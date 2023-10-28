using HelpingHands.Entities;
using HelpingHands.Responses;

namespace HelpingHands.Repositories.Contracts
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetAllPosts();
        Task<Response<string>> CreatePost(Post post);
    }
}
