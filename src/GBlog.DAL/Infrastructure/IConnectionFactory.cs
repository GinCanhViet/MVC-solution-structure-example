using System;
using System.Data;

namespace GBlog.DAL.Infrastructure
{
    public interface IConnectionFactory : IDisposable
    {
        IDbConnection GetConnection { get; }
    }
}
