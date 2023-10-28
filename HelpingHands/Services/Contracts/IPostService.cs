using HelpingHands.Entities;
using HelpingHands.Responses;

namespace HelpingHands.Services.Contracts
{
    public interface IPostService
    {
        Task<Response<IEnumerable<Post>>> GetPosts();
        Task<Response<IEnumerable<Category>>> GetCategories();
    }
}
