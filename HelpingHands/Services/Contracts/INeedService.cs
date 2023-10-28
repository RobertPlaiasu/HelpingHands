using HelpingHands.Dtos;
using HelpingHands.Entities;

namespace HelpingHands.Services.Contracts
{
    public interface INeedService
    {
        Task<IEnumerable<Need>> GetNeeds();
        Task<string> CreateNeed(PostNeedDto need);
        Task<string> UpdateNeed(PostNeedDto need,int id);
    }
}
