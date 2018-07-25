using GBlog.Entities.Models;
using GBlog.DAL.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GBlog.DAL.Service
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
