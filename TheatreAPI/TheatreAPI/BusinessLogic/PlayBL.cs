using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;
using TheatreAPI.Repository;

namespace TheatreAPI.BusinessLogic
{
    public class PlayBL:GenericBL<IPlayRepository,Play>,IPlayBL
    {
        public PlayBL(IPlayRepository playRepository):base(playRepository) { }
    }
}
