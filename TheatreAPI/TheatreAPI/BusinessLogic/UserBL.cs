using TheatreAPI.Models;
using TheatreAPI.Repository;

namespace TheatreAPI.BusinessLogic
{
    public class UserBL : GenericBL<IUserRepository,User>
    { 

        public UserBL(IUserRepository userRepository):base(userRepository)
        {
            
        }

    }
}
