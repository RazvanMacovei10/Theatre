using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public class ActorRepository:GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(AppDbContext appDbContext):base(appDbContext)
        {

        }
    }
}
