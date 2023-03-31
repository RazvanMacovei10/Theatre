using Microsoft.EntityFrameworkCore;
using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;
using TheatreAPI.Repository;

namespace TheatreAPI.BusinessLogic
{
    public class UserBL : GenericBL<IUserRepository,User>,IUserBL
    {
        private readonly AppDbContext _context;
        public UserBL(IUserRepository userRepository, AppDbContext context) : base(userRepository)
        {
            _context = context;
        }

        public async Task<User> GetById(int userId)
        {
            var result = await _context.Users.Where(e => e.Id == userId).FirstOrDefaultAsync();

            return result;
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChangesAsync();
        }
        public async Task<bool> UserExists(string username)
        {
            return await _context.Users.AnyAsync(x => x.Username == username.ToLower());
        }
        public async Task<bool> UserExistsByEmail(string email)
        {
            return await _context.Users.AnyAsync(x => x.Email == email.ToLower());
        }

        public async Task<User> GetByUsername(string username)
        {
            var result = await _context.Users.Include(x=>x.Role).SingleOrDefaultAsync(x => x.Username == username);

            return result;
        }

    }
}
