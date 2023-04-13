using TheatreAPI.Models;

namespace TheatreAPI.IBusinessLogic
{
    public interface ITheathreBL:IGenericBL<Theatre>
    {
        public Task<Theatre> GetByUsername(string username);
    }
}
