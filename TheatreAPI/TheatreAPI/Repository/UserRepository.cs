using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public class UserRepository:GenericRepository<User>,IUserRepository
    {
        public UserRepository(AppDbContext appDbContext):base(appDbContext)
        {

        }
    }
}
