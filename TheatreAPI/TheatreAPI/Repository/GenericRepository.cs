using Microsoft.EntityFrameworkCore;

namespace TheatreAPI.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _context;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            try
            {
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch(Exception e)
            {
                throw new Exception("Couldn't save entity " + e.Message);
            }
            
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<TEntity>> GetAllAsync()
        {
            try
            {
                return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Couldn't receive entities: " + ex.Message);
            }
        }


        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
