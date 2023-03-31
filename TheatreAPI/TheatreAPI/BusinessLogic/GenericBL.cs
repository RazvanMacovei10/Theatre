using Microsoft.EntityFrameworkCore;
using TheatreAPI.IBusinessLogic;
using TheatreAPI.Repository;

namespace TheatreAPI.BusinessLogic
{
    public class GenericBL<TRepository,TEntity> : IGenericBL<TEntity> where TRepository : IGenericRepository<TEntity>
    {
        private readonly IGenericRepository<TEntity> _repository;
        public GenericBL(TRepository repository)
        {
            _repository = repository;
        }

        public Task<TEntity> CreateAsync(TEntity entity)
        {
           return _repository.CreateAsync(entity);
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<TEntity>> GetAllAsync(params string[] navigationProperties)
        {
            var results = await _repository.GetAllAsync(navigationProperties);

            return results;
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
