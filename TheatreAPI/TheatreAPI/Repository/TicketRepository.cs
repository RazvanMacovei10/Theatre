using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public class TicketRepository:GenericRepository<Ticket>,ITicketRepository
    {
        public TicketRepository(AppDbContext appDbContext):base(appDbContext)
        {

        }
    }
}
