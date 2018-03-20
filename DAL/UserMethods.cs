using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace DALOrg
{
    public static class UserMethods
    {
        #region Data Pulling
        #region User
        public static Component.User GetUser(string username, string password)
        {
            DataTable Data = OledbHelper.GetTable("Select * From Users Where UName='" + username + "' AND PWord='" + password + "'");
            DataRow DataR = Data.Rows[0];
            return new Component.User(int.Parse(DataR["UserID"].ToString()), DataR["FName"].ToString(), DataR["LName"].ToString(), int.Parse(DataR["UserType"].ToString()));
        }
        #region Students
        public static DataRowCollection GetStudentsOfGroup(int GroupID)
        {
            string expr = string.Format("PARAMETERS ID Short = {0}; SELECT * FROM GetStudentsByGroupID",GroupID);
            DataTable Data = OledbHelper.GetTable(expr);
            return Data.Rows;
        }
        #endregion
        #region Teachers
        public static DataRowCollection GetTeachers()
        {
            DataTable Data = OledbHelper.GetTable("SELECT Teacher.UserID, Teacher.FName, Teacher.LName FROM Users AS Teacher WHERE (((Teacher.UserType)=0))");
            return Data.Rows;
        }
        #endregion
        #endregion
        #region Classes
        /// <summary>
        /// Returns a Collection Of Student To Home-Class Relations
        /// Fields: Users.UserID, Users.FName, Users.LName, StudentToCourse.SubjectName AS Course, StudentToGrade.Grade, StudentToGrade.ClassNumber
        /// </summary>
        /// <returns></returns>
        public static DataRowCollection GetCourseToGroup()
        {
            string expr = "SELECT * FROM GetCourseToGroup";
            DataTable data = OledbHelper.GetTable(expr);
            return data.Rows;
        }
        #endregion
        #region Lesson
        public static DataRow GetCurrentLesson(int TeacherID)
        {
            return OledbHelper.GetTable("Select * From Lessons L Where L.[StartTime] <  AND L.[EndTime] < GETTIME() AND L.[TeacherID] == " + TeacherID.ToString()).Rows[0];
        }
        /// <summary>
        /// Returns A Collection Of Lesson To Teacher Relations.
        /// Fields: TeacherID, Teacher.FName, Teacher.LName, Lesson.LessonID, Lesson.Day, Lesson.Period, Groups.GroupName, Groups.GroupID, Subjects.SubjectName 
        /// ORDERED By Lesson.Day, Lesson.Period - ASC,ASC
        /// </summary>
        /// <param name="TeacherID"></param>
        /// <returns></returns>
        public static DataRowCollection GetLessonsByTeacher(int TeacherID)
        {
            string expr = string.Format("SELECT * FROM GetLessonsByTeacher WHERE [TeacherID] = {0}", TeacherID);
            DataTable data = OledbHelper.GetTable(expr);
            return data.Rows;
        }
        /// <summary>
        /// Returns A Collection Of Lesson To Group Relations.
        /// Fields: TeacherID, Teacher.FName, Teacher.LName, Lesson.LessonID, Lesson.Day, Lesson.Period, Groups.GroupName, Groups.GroupName, Subjects.SubjectName 
        /// ORDERED By Lesson.Day, Lesson.Period - ASC,ASC
        /// </summary>
        /// <param name="GroupID"></param>
        /// <returns></returns>
        public static DataRowCollection GetLessonsByGroup(int GroupID)
        {
            string expr = string.Format( "SELECT * FROM GetLessonsByGroup WHERE [GroupID] = {0}", GroupID);
            DataTable data = OledbHelper.GetTable(expr);
            return data.Rows;
        }
        #endregion
        #endregion
        #region Data Validation
        public static bool UserExists(string Username, string Password)
        {
            try
            {
                GetUser(Username, Password);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region Data Modification
        #region Add
        public static bool AddUser(string Username, string Password)
        {
            try
            {
                if (!UserExists(Username, Password))
                {
                    string cmd = "INSERT INTO Users (UName,PWord) Values ('" + Username + "','" + Password + "');";
                    OledbHelper.Execute(cmd);
                    return true;
                }
                else
                {
                    throw new Exception("User Exists");
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region Update

        #endregion
        #region Remove
        /// <summary>
        /// Removes The Specified Lesson From The Database
        /// </summary>
        /// <param name="LessonID"></param>
        public static void RemoveLesson(int LessonID)
        {
            string Expr = String.Format("REMOVE * FROM Lessons Where [LessonID]={0}",LessonID);
            OledbHelper.Execute(Expr);
        }

        public static DataRow GetLesson(int lessonID)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
