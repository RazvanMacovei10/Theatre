using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public interface ITheathreRepository:IGenericRepository<Theatre>
    {
        public Task<Theatre> GetByUsername(string username);
    }
}
