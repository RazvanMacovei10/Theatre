namespace TheatreAPI.Repository
{
    public interface IGenericRepository<TEntity>
    {
        Task<IList<TEntity>> GetAllAsync(params string[] navigationProperties);

        Task<TEntity> CreateAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<bool> DeleteAsync(int id);
    }
}
