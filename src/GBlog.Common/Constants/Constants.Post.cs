namespace GBlog.Common
{
    public partial class Constants
    {
        public struct Post
        {
            public struct Paramaters
            {
                public const string PageIndex = "@PageIndex";
                public const string PageSize = "@PageSize";
            }
            public struct StoreProcedure
            {
                public const string GetAllPostByPageIndex = "sp_GetAllPostByPageIndex";
            }
        }
    }
}
