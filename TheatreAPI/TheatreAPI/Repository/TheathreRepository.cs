using Microsoft.EntityFrameworkCore;
using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public class TheathreRepository:GenericRepository<Theatre>, ITheathreRepository
    {
        public TheathreRepository(AppDbContext appDbContext):base(appDbContext)
        {

        }

        public async Task<Theatre> GetByUsername(string username)
        {
            var result = await Context.Theatres.Include(x => x.User).SingleOrDefaultAsync(x => x.User.Username == username);

            return result;
        }
    }
}
