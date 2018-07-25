using GBlog.DAL.Repositories;
using System;

namespace GBlog.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IPostRepository PostRepository { get; }
        void Complete();
    }
}
