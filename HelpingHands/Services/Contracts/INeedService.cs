using HelpingHands.Entities;

namespace HelpingHands.Services.Contracts
{
    public interface INeedService
    {
        Task<IEnumerable<Need>> GetNeeds();
    }
}
