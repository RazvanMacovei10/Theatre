using Microsoft.EntityFrameworkCore;
using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public class UserRoleRepository:GenericRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(AppDbContext appDbContext):base(appDbContext)
        {

        }

        public async Task<UserRole> GetById(int id)
        {
            var result = await Context.Roles.Where(e => e.Id == id).FirstOrDefaultAsync();

            return result;
        }
    }
}
