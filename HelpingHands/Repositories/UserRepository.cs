using HelpingHands.Entities;
using HelpingHands.Repositories.Contracts;

namespace HelpingHands.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly HelpingHandsDbContext _dbContext;

        public UserRepository(HelpingHandsDbContext dbContext) {
            _dbContext = dbContext;
        }
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

        public async Task<User> GetUserById(int id)
        {
            try
            {
                var user = await _dbContext.Users.FindAsync(id);
                return user;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
