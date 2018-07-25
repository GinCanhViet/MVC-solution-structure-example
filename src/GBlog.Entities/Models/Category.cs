namespace GBlog.Entities.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
        public string ImageURL { get; set; }
        public int PageSize { get; set; }
        public bool ShowOnHomePage { get; set; }
        public bool IncludeInTopMenu { get; set; }
    }
}
