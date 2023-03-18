using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;
using TheatreAPI.Repository;

namespace TheatreAPI.BusinessLogic
{
    public class TicketBL:GenericBL<ITicketRepository,Ticket>,ITicketBL
    {
        public TicketBL(ITicketRepository ticketRepository):base(ticketRepository)
        {

        }
    }
}
