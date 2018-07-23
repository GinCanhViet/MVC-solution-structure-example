using GBlog.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GBlog.Data
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(int Id);
        Task<IEnumerable<TEntity>> GetAll();
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
    }
}
