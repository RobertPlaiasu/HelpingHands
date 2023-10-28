using HelpingHands.Entities;

namespace HelpingHands.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task<User> GetUserById(int id);
        /*
        Task<string> Register(User user);
        Task<string> Login(User user);
        */
    }
}
