using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace DAL
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
            DataTable Data = OledbHelper.GetTable("SELECT u.UserID,u.FName, u.LName FROM Users AS u INNER JOIN StudentToGroup AS stg ON u.UserID = stg.StudentID WHERE (((stg.GroupID) = " + GroupID + "));");
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
        public static DataRowCollection GetStudentsToClasses()
        {
            DataTable data = OledbHelper.GetTable("SELECT Users.UserID, Users.FName, Users.LName, Left([GroupName],2) AS Grade, Right([GroupName],2) AS ClassNumber FROM Groups AS Class INNER JOIN (Users INNER JOIN StudentToGroup ON Users.UserID = StudentToGroup.StudentID) ON Class.GroupID = StudentToGroup.GroupID WHERE (((Class.SubjectID)=1));");
            return data.Rows;
        }
        #endregion
        #region Lesson
        public static DataRow GetCurrentLesson(int TeacherID)
        {
            return OledbHelper.GetTable("Select * From Lessons L Where L.[StartTime] <  AND L.[EndTime] < GETTIME() AND L.[TeacherID] == " + TeacherID.ToString()).Rows[0];
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
        #endregion
    }
}
