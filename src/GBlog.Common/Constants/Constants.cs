namespace GBlog.Common
{
    public struct Priority
    {
        public const int Lowest = 0;
        public const int Low = 1;
        public const int Normal = 2;
        public const int High = 3;
        public const int Highest = 4;
    }
    public struct EmailRecipientType
    {
        public const string To = "To";
        public const string Cc = "Cc";
        public const string Bcc = "Bcc";
    }
    public partial class Constants
    {
        public const string IS_VALID = "Field format is incorrect.";

        public struct RegularExpression
        {
            public const string EMAIL = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";
            public const string FILE_NAME = @"^[a-zA-Z0-9_\s-]+$";
            public const string PHONE = @"^\(\d{3}\)\s\d{3}\-\d{4}$";
        }

        public struct ErrorMessage
        {
            public const string IS_REQUIRED_FIELD = "{0} is required.";
            public const string IS_REQUIRED_FIELD_FIRSTNAME = "First Name is required.";
            public const string IS_REQUIRED_FIELD_LASTTNAME = "Last Name is required.";
            public const string IS_REQUIRED_FIELD_ADDRESS1 = "Address is required.";          
            public const string IS_INVALID_FORMAT_FIELD = "{0} must be formatted as {1}.";           
            public const string IS_INVALID_FORMAT_PHONE = "Phone must be formatted as (000) 000-0000.";
            public const string IS_INVALID_FORMAT_DATE = "{0} must be formatted as [mm/dd/yyyy].";
            public const string IS_INVALID_FORMAT_EMAIL = "{0} is invalid.";
            public const string IS_INVALID_FORMAT_PERCENT = "Percentage of business must be from 1 to 100.";
            public const string IS_INVALID_FORMAT_PERCENT_DECIMAL = "Percentage of business must be from 0.01 to 100.";            
        }

        public struct ModuleName
        {
        }

        public struct MasterPage
        {
            public const string LeftMenuLayout = "_LeftMenuLayout";
            public const string HomeLayout = "_HomeLayout";
        }

        public struct Session
        {
            public const string CurrentUserInfo = "CurrentUserInfo";
        }

        public struct Sorting
        {
            public const string ASC = "ASC";
            public const string DESC = "DESC";
            public const string ASCENDING = "Ascending";
            public const string DESCENDING = "Descending";
        }
    }
}
