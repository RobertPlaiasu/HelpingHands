using HelpingHands.Entities;
using HelpingHands.Repositories.Contracts;
using HelpingHands.Services.Contracts;

namespace HelpingHands.Services
{
    public class NeedService : INeedService
    {
        private readonly INeedRepository _needRepository;

        public NeedService(INeedRepository needRepository)
        {
            _needRepository = needRepository;
        }
        public Task<IEnumerable<Need>> GetNeeds()
        {
            return _needRepository.GetNeeds();
        }
    }
}
