using System;
using System.Data;

namespace GBlog.Data.Infrastructure
{
    public interface IConnectionFactory : IDisposable
    {
        IDbConnection GetConnection { get; }
    }
}
