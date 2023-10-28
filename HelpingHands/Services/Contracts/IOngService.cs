using HelpingHands.Dtos;
using HelpingHands.Responses;

namespace HelpingHands.Services.Contracts
{
    public interface IOngService
    {
        Task<Response<IEnumerable<GetOngDto>>> GetOngs();
        Task<Response<GetOngDetailsDto>> GetOng(int id);
    }
}
