using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public class AddressRepository:GenericRepository<Address>,IAddressRepository
    {
        public AddressRepository(AppDbContext appDbContext):base(appDbContext)
        {

        }
    }
}
