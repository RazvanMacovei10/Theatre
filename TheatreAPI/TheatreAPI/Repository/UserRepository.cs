using Microsoft.EntityFrameworkCore;
using TheatreAPI.BusinessLogic;
using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public class UserRepository:GenericRepository<User>,IUserRepository
    {
        public UserRepository(AppDbContext appDbContext):base(appDbContext)
        {
        }
        public async Task<User> GetById(int id)
        {
            var result = await Context.Users.Where(e => e.Id == id).FirstOrDefaultAsync();

            return result;
        }
        public async Task<bool> UserExists(string username)
        {
            return await Context.Users.AnyAsync(x => x.Username == username.ToLower());
        }
        public async Task<bool> UserExistsByEmail(string email)
        {
            return await Context.Users.AnyAsync(x => x.Email == email.ToLower());
        }

        public async Task<User> GetByUsername(string username)
        {
            var result = await Context.Users.Include(x => x.Role).SingleOrDefaultAsync(x => x.Username == username);

            return result;
        }
    }
}
