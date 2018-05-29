using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.Component.Filter;
using DAL.Component.Data;

namespace DAL
{
    public static class Methods
    {
        #region Filtered Table
        public static DataTable GetFilteredTable(string TableName, params Filter[] Filters)
        {
            return GetFilteredTable(TableName, new string[] { "*" }, Filters);
        }
        public static DataTable GetFilteredTable(string TableName, string[] Columns, params Filter[] Filters)
        {
            return GetFilteredTable(TableName, Columns, new FilterCollection(Filters));
        }
        //base method
        public static DataTable GetFilteredTable(string TableName, string[] Columns, FilterCollection Filters)
        {
            //Format an Expression:
            // Handle Columns Part
            #region Format Columns To an SQL Select-Cmpatible Format
            //Form
            Columns = Columns.Select(
                C => //Initializes Variable string C - Current Column 
                string.Format("{0}.{1}", TableName, C) + (
                (C == Columns.Last())//Setsa boolean Expression that checks if C is the Last Column
                ? ""//If Expression is true add a blank string (Do nothing)
                : "," //If Expression is false add ","
                ) + " "
                ).ToArray();
            #endregion
            #region Create ColumnsString
            string ColumnsString = "";
            foreach (string Column in Columns) { ColumnsString += Column; }
            string expr = string.Format("SELECT {0}", ColumnsString);
            #endregion
            // Handle TableName Part
            expr += string.Format(" FROM {0}", TableName);
            // Handle Conditions Part
            string[] Conditions = Filters.GetQueries();
            if (Conditions.Count() > 0)
            {
                #region Format Conditions To an SQL Condition Format
                //Format Conditions To Easily Chain Them.
                //Formats The Last Condition To "(ConditionString)"
                //Formats The Other Conditions To "(ConditionString) AND "
                Conditions = Conditions.Select(
                    C => //Initializes Variable string C - Current Condition
                    string.Format("({0})", C) + (
                    ((C == Conditions.Last())) //Sets a boolean Expression that checks if C is the Last Condition
                    ? "" //If Expression is true add a blank string (Do nothing),
                    : " AND " //If Expression is false add " AND ".
                    )
                    ).ToArray();
                #endregion
                #region Create ConditionsString
                string ConditionsString = "";
                foreach (string Condition in Conditions) { ConditionsString += Condition; }
                expr += string.Format(" WHERE ({0})", ConditionsString);
                #endregion
            }
            // Close expression With a Semicolon
            expr += ";";
            return OledbHelper.GetTable(expr);
        }
        #endregion
        #region Validate
        public static bool UserExists(string Username, string Password)
        {
            try
            {
                GetUserByCredentials(Username, Password);
            }
            catch
            { return false; }
            return false;
        }
        public static bool IsUsedID(string str)
        {
            try
            {
                Filter FUsername = Filter.CloneWithValue(Filters.User.Username, str);
                DataRow dr = GetFilteredTable(User.Tablename, User.Columns, FUsername).Rows[0];
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region Pull
        #region User
        public static User GetUserByID(int UserID)
        {
            DataRow dr = GetFilteredTable(User.Tablename, User.Columns, Filter.CloneWithValue(Filters.User.ID, UserID.ToString())).Rows[0];
            return new User(
                (int)dr["UserID"],
                (string)dr["FName"],
                (string)dr["LName"],
                (int)dr["UserType"]
                );
        }
        public static User GetUserByCredentials(string Username, string Password)
        {
            Filter FUsername = Filter.CloneWithValue(Filters.User.Username, Username);
            Filter FPassword = Filter.CloneWithValue(Filters.User.Password, Password);
            DataRow dr = GetFilteredTable(User.Tablename, User.Columns, FUsername, FPassword).Rows[0];
            return new User(
            (int)dr["UserID"],
            (string)dr["FName"],
            (string)dr["LName"],
            (int)dr["UserType"]
            );
        }
        #endregion #endregion
        #region Lesson
        public static Lesson GetLessonByID(int LessonID)
        {
            Filter FLessonID = Filter.CloneWithValue(Filters.Lesson.LessonID, LessonID.ToString());
            DataRow dt = GetFilteredTable(Lesson.Tablename, Lesson.Columns, FLessonID).Rows[0];
            return new Lesson(
                (int)dt["LessonID"],
                (int)dt["GroupID"],
                (int)dt["TeacherID"],
                (int)dt["SubjectID"],
                (int)dt["Day"],
                (int)dt["Period"]
                );
        }
        /// <summary>
        /// Returns A Collection Of Lessons Given By The Teacher.
        /// Fields: TeacherID, Teacher.FName, Teacher.LName, Lesson.LessonID, Lesson.Day, Lesson.Period, Groups.GroupName, Groups.GroupID, Subjects.SubjectName 
        /// ORDERED By Lesson.Day, Lesson.Period - ASC,ASC
        /// </summary>
        /// <param name="TeacherID"></param>
        /// <returns></returns>
        public static Lesson[] GetLessonsByTeacher(int TeacherID)
        {
            List<Lesson> Lessons = new List<Lesson>();
            Filter FTeacherID = Filter.CloneWithValue(Filters.Lesson.TeacherID, TeacherID.ToString());
            DataTable dt = GetFilteredTable(Lesson.Tablename, Lesson.Columns, FTeacherID);
            foreach (DataRow l in dt.Rows)
            {
                Lesson Lesson = new Lesson(
                    (int)l[0],
                    (int)l[1],
                    (int)l[2],
                    (int)l[3],
                    (int)l[4],
                    (int)l[5]
                    );
                Lessons.Add(Lesson);
            }
            return Lessons.ToArray();
        }
        /// <summary>
        /// Returns A Collection Of Lessons Taken By The Group.
        /// Fields: TeacherID, Teacher.FName, Teacher.LName, Lesson.LessonID, Lesson.Day, Lesson.Period, Groups.GroupName, Groups.GroupName, Subjects.SubjectName 
        /// ORDERED By Lesson.Day, Lesson.Period - ASC,ASC
        /// </summary>
        /// <param name="GroupID"></param>
        /// <returns></returns>
        public static Lesson[] GetLessonsByGroup(int GroupID)
        {
            List<Lesson> Lessons = new List<Lesson>();
            Filter FGroupID = Filter.CloneWithValue(Filters.Lesson.GroupID, GroupID.ToString());
            DataTable dt = GetFilteredTable(Lesson.Tablename, Lesson.Columns, FGroupID);
            foreach (DataRow l in dt.Rows)
            {
                Lesson Lesson = new Lesson(
                    (int)l[0],
                    (int)l[1],
                    (int)l[2],
                    (int)l[3],
                    (int)l[4],
                    (int)l[5]
                    );
                Lessons.Add(Lesson);
            }
            return Lessons.ToArray();
        }
        #endregion
        #region Group
        public static string GetGroupName(int GroupID)
        {
            Filter FGroupID = Filter.CloneWithValue(Filters.Group.GroupID, GroupID.ToString());
            DataTable dt = GetFilteredTable(Group.Tablename, new string[] { "GroupName" }, FGroupID);
            return dt.Rows[0][0].ToString();
        }
        #endregion
        #region Subject
        public static string GetSubjectName(int SubjectID)
        {
            Filter FSubjectID = Filter.CloneWithValue(Filters.Subject.SubjectID, SubjectID.ToString());
            DataTable dt = GetFilteredTable(Subject.Tablename, new string[] { "SubjectName" }, FSubjectID);
            return dt.Rows[0][0].ToString();
        }
        #endregion
        #endregion
        #region Push
        #region User
        /// <summary>
        /// Creates a user with the provided information,
        /// returns the created user's ID.
        /// </summary>
        /// <param name="Username">Created User's Username</param>
        /// <param name="Password">Created User's Password</param>
        /// <param name="FName">Created User's First Name</param>
        /// <param name="LName">Created User's Surname</param>
        /// <param name="UserType">Created User's Type:
        /// -1: Admin, 0: Teacher, 1: Student</param>
        public static int CreateUser(string Username, string Password, string FName, string LName, int UserType)
        {
            if (!UserExists(Username, Password))
            {
                try
                {
                    string cmd = string.Format("INSERT INTO Users ([UName],[PWord],[FName],[LName],[UserType]) VALUES ('{0}','{1}','{2}','{3}',{4});", Username, Password, FName, LName, UserType.ToString());
                    OledbHelper.Execute(cmd);
                    return GetUserByCredentials(Username, Password).ID;
                }
                catch
                {
                    return -1;
                }
            }
            return -1;
        }
        #endregion
        #endregion
        #region Update

        #endregion
    }
}
