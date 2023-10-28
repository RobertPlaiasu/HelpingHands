using HelpingHands.Entities;

namespace HelpingHands.Repositories.Contracts
{
    public interface IOngRepository
    {
        Task<Ong> GetOngById(int id);
        Task<IEnumerable<Ong>> GetOngs();
        Task<Ong> UpdateOng(Ong ong);   
    }
}
