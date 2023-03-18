using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public class PlayTypeRepository : GenericRepository<PlayType>, IPlayTypeRepository
    {
        public PlayTypeRepository(AppDbContext appDbContext) : base(appDbContext) { }

    }
}
