using GBlog.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GBlog.Data.Repositories
{
    public interface IPostRepository : IGenericRepository<Post>
    {
        Task<IEnumerable<Post>> GetAllPostByPageIndexAsync(int pageIndex, int pageSize);
    }
}
