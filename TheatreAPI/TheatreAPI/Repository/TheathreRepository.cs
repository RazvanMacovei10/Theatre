using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public class TheathreRepository:GenericRepository<Theatre>, ITheathreRepository
    {
        public TheathreRepository(AppDbContext appDbContext):base(appDbContext)
        {

        }
    }
}
