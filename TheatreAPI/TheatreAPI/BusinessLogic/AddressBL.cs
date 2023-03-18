using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;
using TheatreAPI.Repository;

namespace TheatreAPI.BusinessLogic
{
    public class AddressBL:GenericBL<IAddressRepository,Address>, IAddressBL
    {
        public AddressBL(IAddressRepository addressRepository):base(addressRepository)
        {

        }
    }
}
