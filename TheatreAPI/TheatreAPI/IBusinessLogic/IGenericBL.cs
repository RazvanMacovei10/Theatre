﻿namespace TheatreAPI.IBusinessLogic
{
    public interface IGenericBL<T>
    {

        Task<IList<T>> GetAllAsync();

        Task<T> CreateAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<bool> DeleteAsync(int id);

    }
}
