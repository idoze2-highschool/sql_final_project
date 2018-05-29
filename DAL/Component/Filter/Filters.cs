using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Component.Filter
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
        #region Subject Filters
        public static class Subject
        {
            public static readonly Filter SubjectID = new Filter(
               "SubjectID",
               "Subjects.[SubjectID] = [CheckValue]",
               "SubjectID = [FormatValue]",
               typeof(int)
               );
            public static readonly Filter InCourseID = new Filter(
               "InCourseID",
               "Subjects.[SubjectID] In ( Select SubjectToCourse.[SubjectID] FROM SubjectToCourse Where (SubjectToCourse.[CourseID] = [CheckValue]))",
               "Part Of Course With ID = [FormatValue]",
               typeof(int)
               );
        }
        #endregion
        #region Group Filters
        public static class Group
        {
            public static readonly Filter HasStudent = new Filter(
                      "HasStudent",
                      " Groups.[GroupID] in (Select StudentToGroup.[GroupID] FROM StudentToGroup Where (StudentToGroup.[StudentID] = [CheckValue]))",
                      "Has Student [FormatValue]",
                      typeof(int)
                      );
            public static readonly Filter InCourse = new Filter(
                "InCourse",
                "Groups.[CourseID] = [CheckValue]",
                "In Course [FormatValue]",
                typeof(int)
                );
            public static readonly Filter NameLike = new Filter(
                "Name Like",
                "Groups.[GroupName] Like '[CheckValue]'",
                "Name Like '[FormatValue]'",
                typeof(string)
                );
            public static readonly Filter GroupID = new Filter(
                "ID",
                "Groups.[GroupID] = [CheckValue]",
                "ID = FormatValue",
                typeof(int)
                );
        }
        #endregion
        #region Lesson Filters
        public static class Lesson
        {
            public static readonly Filter TeacherID = new Filter(
                "TeacherID",
                "Lessons.[TeacherID] = [CheckValue]",
                "TeacherID = [FormatValue]",
                typeof(int)
                );
            public static readonly Filter GroupID = new Filter(
                "GroupID",
                "Lessons.[GroupID] = [CheckValue]",
                "GroupID = [FormatValue]",
                typeof(int)
                );
            public static readonly Filter SubjectID = new Filter(
                "SubjectID",
                "Lessons.[SubjectID] = [CheckValue]",
                "SubjectID = [FormatValue]",
                typeof(int)
                );
            public static readonly Filter LessonID = new Filter(
                "LessonID",
                "Lessons.[LessonID] = [CheckValue]",
                "LessonID = [FormatValue]",
                typeof(int)
                );
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
        #region Subject Filters
        public static readonly FilterCollection SubjectFilters = new FilterCollection(
            Filters.Subject.SubjectID,
            Filters.Subject.InCourseID
            );
        #endregion
        #region Group Filters
        public static readonly FilterCollection GroupFilters = new FilterCollection(
            Filters.Group.InCourse,
            Filters.Group.HasStudent,
            Filters.Group.NameLike
            );
        #endregion
        #region Lesson Filters
        public static class Lesson
        {
            public static readonly FilterCollection LessonFilters = new FilterCollection(
                Filters.Lesson.GroupID,
                Filters.Lesson.LessonID,
                Filters.Lesson.SubjectID,
                Filters.Lesson.TeacherID
                );
        }
        #endregion
    }
}
