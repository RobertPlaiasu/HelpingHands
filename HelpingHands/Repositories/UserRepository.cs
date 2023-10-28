using HelpingHands.Entities;
using HelpingHands.Repositories.Contracts;

namespace HelpingHands.Repositories
{
    public class UserRepository : IUserRepository
    { 
        /*
        public async Task<string> Login(User user)
        {
            return user.Name;
        }
        */
        public Task<string> Register(User user)
        {
            throw new NotImplementedException();
        }

        Task<User> IUserRepository.GetUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
