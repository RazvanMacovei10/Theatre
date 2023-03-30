using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public class RegisterFormRepository:GenericRepository<RegisterForm>, IRegisterFormRepository
    {
        public RegisterFormRepository(AppDbContext appDbContext):base(appDbContext)
        {

        }
    }
}
