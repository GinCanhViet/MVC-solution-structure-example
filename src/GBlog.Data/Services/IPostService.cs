using GBlog.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GBlog.Data
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetAllPostByPageIndexAsync(int pageIndex, int pageSize);
    }
}
