using TheatreAPI.IBusinessLogic;
using TheatreAPI.Repository;

namespace TheatreAPI.BusinessLogic
{
    public class GenericBL<TRepository,TEntity> : IGenericBL<TEntity> where TRepository : IGenericRepository<TEntity>
    {
        private readonly IGenericRepository<TEntity> Repository;
        public GenericBL(TRepository repository)
        {
            Repository = repository;
        }

        public Task<TEntity> CreateAsync(TEntity entity)
        {
           return Repository.CreateAsync(entity);
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
