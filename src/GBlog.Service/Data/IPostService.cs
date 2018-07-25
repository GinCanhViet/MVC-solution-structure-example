using GBlog.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GBlog.Service.Data
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetAllPostByPageIndexAsync(int pageIndex, int pageSize);
    }
}
