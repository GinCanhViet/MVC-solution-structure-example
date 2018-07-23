using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GBlog.Data
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> IGenericRepository<TEntity>.Get(int Id)
        {
            throw new NotImplementedException();
        }
        Task<IEnumerable<TEntity>> IGenericRepository<TEntity>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task IGenericRepository<TEntity>.Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        Task IGenericRepository<TEntity>.Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        Task IGenericRepository<TEntity>.Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
