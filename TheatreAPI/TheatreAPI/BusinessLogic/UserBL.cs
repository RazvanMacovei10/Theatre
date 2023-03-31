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
            var result = await (Repository as IUserRepository).GetById(userId);

            return result;
        }
        public async Task<bool> UserExists(string username)
        {
            return await (Repository as IUserRepository).UserExists(username);
        }
        public async Task<bool> UserExistsByEmail(string email)
        {
            return await (Repository as IUserRepository).UserExistsByEmail(email);
        }

        public async Task<User> GetByUsername(string username)
        {
            var result = await (Repository as IUserRepository).GetByUsername(username);

            return result;
        }

    }
}
