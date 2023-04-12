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

        public async Task<UserRole> GetById(int userId)
        {
            var result = await (Repository as IUserRoleRepository).GetById(userId);

            return result;
        }
    }
}
