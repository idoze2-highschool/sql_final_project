using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Component
{
    public static class Filters
    {
        #region NullFilter
        public static readonly Filter NullFilter = new Filter("NullFilter", "", "NullFilter", typeof(string));
        #endregion
        #region User Filters
        public static class User
        {
            public static readonly Filter InGroup = new Filter(
                "InGroup",
                "Users.[UserID] in (SELECT StudentToGroup.[StudentID] as UserID FROM StudentToGroup WHERE (StudentToGroup.[GroupID] = [CheckValue]))",
                "InGroup: [FormatValue]",
                typeof(int)
                );
            public static readonly Filter Type = new Filter(
                "Type",
                "Users.[UserType] = [CheckValue]",
                "Type: [FormatValue]",
                typeof(int)
                );
            public static readonly Filter FNameLike = new Filter(
                "FName Like",
                "Users.[FName] Like '[CheckValue]'",
                "FName Like '[FormatValue]'",
                typeof(string)
                );
            public static readonly Filter LNameLike = new Filter(
                "LName Like",
                "Users.[LName] Like '[CheckValue]'",
                "LName Like '[FormatValue]'",
                typeof(string)
                );
            public static readonly Filter ID = new Filter(
                "ID",
                "Users.[UserID] = [CheckValue]",
                "ID: [FormatValue]",
                typeof(int)
                );
            public static readonly Filter Username = new Filter(
                "Username",
                "Users.[Username] = [CheckValue]",
                "Username: [FormatValue]",
                typeof(string)
                );
            public static readonly Filter Password = new Filter(
                "Password",
                "Users.[Password] = [CheckValue]",
                "Password: [FormatValue]",
                typeof(string)
                );
        }
        #endregion
        #region Course Filters
        public static class Course
        {
        }
        #endregion
    }
    public static class FilterCollections
    {
        #region NullFilter
        public static readonly FilterCollection NullFilterCollection = new FilterCollection();
        #endregion
        #region User Filters
        public static readonly FilterCollection UserFilters = new FilterCollection(
            Filters.User.InGroup,
            Filters.User.Type,
            Filters.User.FNameLike,
            Filters.User.LNameLike
            );
        #endregion
        #region Course Filters
        public static readonly FilterCollection CourseFilters = new FilterCollection(
            );

        #endregion
    }
}
