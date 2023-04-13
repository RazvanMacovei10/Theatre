using Microsoft.EntityFrameworkCore;
using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public class EventRepository:GenericRepository<Event>, IEventRepository
    {
        public EventRepository(AppDbContext appDbContext):base(appDbContext)
        {
        }
    }
}
