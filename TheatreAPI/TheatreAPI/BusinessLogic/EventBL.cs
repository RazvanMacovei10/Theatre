using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;
using TheatreAPI.Repository;

namespace TheatreAPI.BusinessLogic
{
    public class EventBL:GenericBL<IEventRepository,Event>,IEventBL
    {
        public EventBL(IEventRepository eventRepository):base(eventRepository) 
        {

        }
    }
}
