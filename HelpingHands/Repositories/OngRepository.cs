using HelpingHands.Entities;
using HelpingHands.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace HelpingHands.Repositories
{
    public class OngRepository : IOngRepository
    {
        private readonly HelpingHandsDbContext _context;

        public OngRepository(HelpingHandsDbContext context)
        {
            _context = context;
        }
        public async Task<Ong> GetOngById(int id)
        {
            return await _context.Ongs.FindAsync(id);
        }

        public async Task<IEnumerable<Ong>> GetOngs()
        {
            return await _context.Ongs.ToListAsync();
        }
    }
}
