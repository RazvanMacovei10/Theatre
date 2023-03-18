using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;
using TheatreAPI.Repository;

namespace TheatreAPI.BusinessLogic
{
    public class ActorBL:GenericBL<IActorRepository,Actor>,IActorBL
    {
        public ActorBL(IActorRepository actorRepository):base(actorRepository)
        {

        }
    }
}
