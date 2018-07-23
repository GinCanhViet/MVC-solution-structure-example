
namespace GBlog.Data.Models
{
    public class Post : BaseEntity
    {
        public string UrlSlug { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
