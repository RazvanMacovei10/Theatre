using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public class UserRoleRepository:GenericRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(AppDbContext appDbContext):base(appDbContext)
        {

        }
    }
}
