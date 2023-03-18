using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;
using TheatreAPI.Repository;

namespace TheatreAPI.BusinessLogic
{
    public class TheathreBL:GenericBL<ITheathreRepository,Theatre>,ITheathreBL
    {
        public TheathreBL(ITheathreRepository theathreRepository):base(theathreRepository)
        {

        }
    }
}
