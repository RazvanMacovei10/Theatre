using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;
using TheatreAPI.Repository;

namespace TheatreAPI.BusinessLogic
{
    public class UserRoleBL:GenericBL<IUserRoleRepository,UserRole>,IUserRoleBL
    {
        public UserRoleBL(IUserRoleRepository userRoleRepository):base(userRoleRepository)
        {

        }
    }
}
