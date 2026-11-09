using System;
using System.Collections.Generic;
using System.Text;

namespace Repository_Expert
{
    internal interface IGenericInterface<T> where T: class
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
