namespace TheatreAPI.Repository
{
    public interface IGenericRepository<TEntity>
    {
        Task<IList<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(int id);

        Task<TEntity> CreateAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<bool> DeleteAsync(int id);
    }
}
