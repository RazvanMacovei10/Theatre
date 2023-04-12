using Microsoft.EntityFrameworkCore;
using TheatreAPI.IBusinessLogic;
using TheatreAPI.Repository;

namespace TheatreAPI.BusinessLogic
{
    public class GenericBL<TRepository,TEntity> : IGenericBL<TEntity> where TRepository : IGenericRepository<TEntity>
    {
        private readonly IGenericRepository<TEntity> _repository;
        public IGenericRepository<TEntity> Repository { get { return _repository; } }
        public GenericBL(TRepository repository)
        {
            _repository = repository;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
           return await _repository.CreateAsync(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
           return await _repository.DeleteAsync(id);
        }

        public async Task<IList<TEntity>> GetAllAsync(params string[] navigationProperties)
        {
            var results = await _repository.GetAllAsync(navigationProperties);

            return results;
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
