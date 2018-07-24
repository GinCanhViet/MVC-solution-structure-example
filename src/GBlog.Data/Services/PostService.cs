using GBlog.Data.Models;
using GBlog.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBlog.Data
{
    public class PostService : IPostService
    {
        IUnitOfWork _unitOfWork;
        public PostService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Post>> GetAllPostByPageIndexAsync(int pageIndex, int pageSize)
        {
            return await _unitOfWork.PostRepository.GetAllPostByPageIndexAsync(pageIndex, pageSize);
        }
    }
}
