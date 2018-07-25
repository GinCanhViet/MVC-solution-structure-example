using GBlog.Service.Data;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace GBlog.Controllers
{
    public class PostController : Controller
    {
        IPostService _postService;

        public PostController()
        {

        }

        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        [HttpGet]
        public async Task<JsonResult> GetAllBlogPostsByPageIndex(int pageIndex, int pageSize)
        {
            var resultData = await _postService.GetAllPostByPageIndexAsync(pageIndex, pageSize);
            return new JsonResult() { Data = resultData, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}