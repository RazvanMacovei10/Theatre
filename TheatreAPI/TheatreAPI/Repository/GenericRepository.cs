using Microsoft.EntityFrameworkCore;

namespace TheatreAPI.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _context;
        public AppDbContext Context { get { return _context; } }
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

        public async Task<bool> DeleteAsync(int id)
        {
            var entity=await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                throw new Exception($"{nameof(entity)} could not be found");
            }

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IList<TEntity>> GetAllAsync(params string[] navigationProperties)
        {
            try
            {
                IQueryable<TEntity> query=_context.Set<TEntity>();
                foreach(string navigationProperty in navigationProperties)
                {
                    query = query.Include(navigationProperty);
                }
                return await query.AsNoTracking().ToListAsync();
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
