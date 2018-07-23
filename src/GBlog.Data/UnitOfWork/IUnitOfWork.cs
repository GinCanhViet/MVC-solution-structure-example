using GBlog.Data.Repositories;
using System;

namespace GBlog.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IPostRepository PostRepository { get; }
        void Complete();
    }
}
