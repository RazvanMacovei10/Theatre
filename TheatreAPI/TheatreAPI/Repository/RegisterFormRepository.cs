using Microsoft.EntityFrameworkCore;
using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public class RegisterFormRepository:GenericRepository<RegisterForm>, IRegisterFormRepository
    {
        public RegisterFormRepository(AppDbContext appDbContext):base(appDbContext)
        {

        }

        public async Task<RegisterForm> GetById(int id)
        {
            var result = await Context.RegisterForms.Where(e => e.Id == id).Include(x=>x.Address).FirstOrDefaultAsync();

            return result;
        }
    }
}
