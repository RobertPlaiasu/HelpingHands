using HelpingHands.Dtos;
using HelpingHands.Responses;

namespace HelpingHands.Services.Contracts.UserService
{
    public interface IUserService
    {
        // Task<GetUserDto> GetUserByClaim();

        Task<Response<GetUserDto>> GetUserById(int id);
    }
}
