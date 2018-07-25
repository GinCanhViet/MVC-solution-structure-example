using Dapper;
using GBlog.DAL.Infrastructure;
using GBlog.Entities.Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using GBlog.Common;

namespace GBlog.DAL.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        IConnectionFactory _connectionFactory;
        public PostRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public async Task<IEnumerable<Post>> GetAllPostByPageIndexAsync(int pageIndex, int pageSize)
        {
            var query = Constants.Post.StoreProcedure.GetAllPostByPageIndex;
            var param = new DynamicParameters();
            param.Add(name: Constants.Post.Paramaters.PageIndex, value: pageIndex);
            param.Add(name: Constants.Post.Paramaters.PageSize, value: pageSize);
            var list = await SqlMapper.QueryAsync<Post>(_connectionFactory.GetConnection, query, param, commandType: CommandType.StoredProcedure);
            return list;
        }
    }
}
