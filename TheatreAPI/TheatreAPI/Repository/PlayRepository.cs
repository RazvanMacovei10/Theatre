using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public class PlayRepository : GenericRepository<Play>, IPlayRepository
    {
        public PlayRepository(AppDbContext appDbContext) : base(appDbContext) { }
    }
}
