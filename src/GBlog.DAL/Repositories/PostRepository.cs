using Dapper;
using GBlog.DAL.Infrastructure;
using GBlog.Entities.Models;
using GBlog.Common;
using GBlog.Service.Caching;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace GBlog.DAL.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        IConnectionFactory _connectionFactory;
        InMemoryCache _memoryCacheService;
        public PostRepository(IConnectionFactory connectionFactory, InMemoryCache memoryCacheService)
        {
            _connectionFactory = connectionFactory;
            _memoryCacheService = memoryCacheService;
        }
        public async Task<IEnumerable<Post>> GetAllPostByPageIndexAsync(int pageIndex, int pageSize)
        {
            var list = _memoryCacheService.GetOrSet($"GetAllPostByPageIndex{pageIndex}{pageSize}", 10, async () =>
              {
                  var query = Constants.Post.StoreProcedure.GetAllPostByPageIndex;
                  var param = new DynamicParameters();
                  param.Add(name: Constants.Post.Paramaters.PageIndex, value: pageIndex);
                  param.Add(name: Constants.Post.Paramaters.PageSize, value: pageSize);
                  return await SqlMapper.QueryAsync<Post>(_connectionFactory.GetConnection, query, param, commandType: CommandType.StoredProcedure);
              });
            return await list;
        }
    }
}
