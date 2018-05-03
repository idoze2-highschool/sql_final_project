using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Component;

namespace Client.Components.Base
{
    public enum Component
    {
        User,
        Course,
        Group,
        Subject
    }
    public static class ComponentMethods
    {
        public static FilterCollection GetFilters(this Component Component)
        {
            switch (Component)
            {
                default:
                    break;
                case Component.User:
                    return FilterCollections.UserFilters;
                case Component.Course:
                    return FilterCollections.CourseFilters;
                case Component.Subject:
                    return FilterCollections.UserFilters;
                case Component.Group:
                    return FilterCollections.UserFilters;

            }
            return FilterCollections.NullFilterCollection;
        }
        public static string GetTableName(this Component Component)
        {
            switch (Component)
            {
                case Component.User:
                    return "Users";
                case Component.Course:
                    return "Courses";
                case Component.Group:
                    return "Groups";
                case Component.Subject:
                    return "Subjects";
            }
            return "";
        }
        public static string[] GetTableColumns(this Component Component)
        {
            switch (Component)
            {
                case Component.User:
                    return new string[] {
                        "[UserID] as ID",
                        "[FName] as Name",
                        "[LName] as Surname",
                        "[UserType] as Type"
                    };
            }
            return new string[] { };
        }
    }
}
