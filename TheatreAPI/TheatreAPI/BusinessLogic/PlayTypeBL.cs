using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;
using TheatreAPI.Repository;

namespace TheatreAPI.BusinessLogic
{
    public class PlayTypeBL:GenericBL<IPlayTypeRepository,PlayType>,IPlayTypeBL
    {
        public PlayTypeBL(IPlayTypeRepository playTypeRepository):base(playTypeRepository)
        {

        }
    }
}
