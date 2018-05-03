using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using DAL.Component;

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
        public static string GetNameOfUser(int UserID)
        {
            string expr = string.Format(" SELECT ([FName]&' '&[LName]) as Name FROM Users Where ([UserID] = {0})", UserID);
            return OledbHelper.GetTable(expr).Rows[0]["Name"].ToString();
        }
        #region Students
        public static DataRowCollection GetStudentsOfGroup(int GroupID)
        {
            string expr = string.Format("SELECT * FROM GetStudentsByGroup WHERE GetStudentsByGroup.[GroupID] = {0}", GroupID);
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
        public static bool IsTeacherAvailable(int teacherID, int day, int period)
        {
            string expr = string.Format("SELECT Count(GetLessonsByTeacher.LessonID) AS LessonCount FROM GetLessonsByTeacher HAVING (GetLessonsByTeacher.[TeacherID]={0}) AND (GetLessonsByTeacher.[Day]={1}) AND (GetLessonsByTeacher.[Period]={2});", teacherID, day, period);
            return ((int)OledbHelper.GetTable(expr).Rows[0]["LessonCount"]) == 0;
        }
        #endregion
        #endregion
        #region Course
        public static DataRowCollection GetCourseToTeacher(int teacherID)
        {
            string expr = String.Format("SELECT * FROM GetTeacherToCourse Where TeacherID = {0}", teacherID);
            DataTable data = OledbHelper.GetTable(expr);
            return data.Rows;
        }
        public static DataRowCollection GetCourseToAvailableTeachers(int Day, int Period, int CourseID)
        {
            string expr = String.Format("SELECT [Users].[FName] & ' ' & [Users].[LName] AS Name, Users.[UserID] AS TeacherID FROM Users INNER JOIN GetTeacherToCourse ON Users.UserID = GetTeacherToCourse.TeacherID WHERE (((GetTeacherToCourse.TeacherID) Not In (SELECT GetLessonsByTeacher.[TeacherID] FROM  GetLessonsByTeacher WHERE (((GetLessonsByTeacher.[Day])={1})) AND ((GetLessonsByTeacher.[Period])={2}))) AND ((GetTeacherToCourse.CourseID)={0}));", CourseID, Day, Period);
            DataTable data = OledbHelper.GetTable(expr);
            return data.Rows;
        }
        public static DataRowCollection GetCourseToTeacher(int teacherID, int grade)
        {
            string expr = String.Format("SELECT * FROM GetTeacherToCourse Where TeacherID = {0} AND Grade = {1}", teacherID, grade);
            DataTable data = OledbHelper.GetTable(expr);
            return data.Rows;
        }
        public static DataRowCollection GetCourseAndTeacherToSubjects(int CourseID, int TeacherID)
        {
            string expr = String.Format("SELECT * FROM GetCourseAndTeacherToSubjects Where CourseID = {0} AND TeacherID = {1}", CourseID, TeacherID);
            DataTable data = OledbHelper.GetTable(expr);
            return data.Rows;
        }
        public static DataRowCollection GetCourseToGroup()
        {
            string expr = "SELECT * FROM GetCourseToGroup";
            DataTable data = OledbHelper.GetTable(expr);
            return data.Rows;
        }
        public static DataRowCollection GetCourseToAvailableGroups(int courseID, int day, int period)
        {
            string expr = String.Format("SELECT GetCourseToGroup.[GroupID],GetCourseToGroup.[GroupName] FROM GetCourseToGroup WHERE (((GetCourseToGroup.[GroupID]) Not In (SELECT MainGroupID FROM GetLessonsOfGroupMembers WHERE (Day = {1} AND Period = {2}))) AND (GetCourseToGroup.[CourseID])={0});", courseID, day, period);
            DataTable data = OledbHelper.GetTable(expr);
            return data.Rows;
        }
        public static DataRow GetCourseOfGroup(int GroupID)
        {
            string expr = string.Format("SELECT * FROM GetCourseToGroup WHERE (GetCourseToGroup.[GroupID] = {0})", GroupID);
            return OledbHelper.GetTable(expr).Rows[0];
        }
        public static string GetCourseName(int CourseID)
        {
            string expr = string.Format("SELECT Course.[CourseName] FROM Course WHERE (Course.[CourseID] = {0})", CourseID);
            return (string)OledbHelper.GetTable(expr).Rows[0][0];
        }
        public static int GetCourseGrade(int CourseID)
        {
            string expr = string.Format("SELECT Course.[Grade] From Course Where (Course.[CourseID] = {0})", CourseID);
            return (int)OledbHelper.GetTable(expr).Rows[0][0];
        }
        #endregion
        #region Lesson
        public static DataRow GetLesson(int lessonID)
        {
            throw new NotImplementedException();
        }
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
            string expr = string.Format("SELECT * FROM GetLessonsOfGroupMembers WHERE [MainGroupID] = {0}", GroupID);
            DataTable data = OledbHelper.GetTable(expr);
            return data.Rows;
        }
        #endregion
        #region Group
        public static DataRowCollection GetGroupsOfCourse(int CourseID)
        {
            string expr = String.Format("SELECT * FROM GetCourseToGroup Where CourseID = {0}", CourseID);
            DataTable data = OledbHelper.GetTable(expr);
            return data.Rows;
        }
        public static string GetGroupName(int GroupID)
        {
            string expr = string.Format("SELECT Groups.[GroupName] From Groups WHERE (Groups.[GroupID] = {0});", GroupID);
            return (string)OledbHelper.GetTable(expr).Rows[0][0];
        }
        public static bool IsGroupAvailable(int groupID, int day, int period)
        {
            string expr = string.Format("SELECT Count(GetLessonsByGroup.LessonID) AS LessonCount FROM GetLessonsByGroup HAVING (GetLessonsByGroup.[GroupID]={0}) AND (GetLessonsByGroup.[Day]={1}) AND (GetLessonsByGroup.[Period]={2});", groupID, day, period);
            return ((int)OledbHelper.GetTable(expr).Rows[0]["LessonCount"]) == 0;
        }
        #endregion
        #region Grade
        public static DataRow GetTeacherToMinAndMaxGrades(int TeacherID)
        {
            string expr = String.Format("SELECT Min,Max FROM GetTeacherToMinAndMaxGrades WHERE TeacherID = {0}", TeacherID);
            return OledbHelper.GetTable(expr).Rows[0];
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
        public static void AddLesson(int TeacherID, int GroupID, int SubjectID, int Day, int Period)
        {
            string Expr = string.Format("INSERT INTO Lessons ([TeacherID],[GroupID],[SubjectID],[Day],[Period]) Values ({0},{1},{2},{3},{4})", TeacherID, GroupID, SubjectID, Day, Period);
            OledbHelper.Execute(Expr);
        }
        #endregion
        #region Update
        #region Lesson
        public static void UpdateLesson(int LessonID, int TeacherID, int GroupID, int SubjectID, int Day, int Period)
        {
            string expr = string.Format("UPDATE Lessons SET Lessons.GroupID = {1}, Lessons.TeacherID = {2}, Lessons.SubjectID = {3}, Lessons.[Day] = {4}, Lessons.Period = {5} WHERE (((Lessons.LessonID)={0}));", LessonID, GroupID, TeacherID, SubjectID, Day, Period);
            OledbHelper.Execute(expr);
        }
        #endregion
        #region Group
        //Update A Group's GroupName
        public static void UpdateGroup(int GroupID, string GroupName)
        {
            string expr = string.Format("UPDATE Groups SET Groups.GroupName = '{1}' WHERE (((Groups.GroupID)={0}));", GroupID, GroupName);
            OledbHelper.Execute(expr);
        }
        //Update A Group's CourseID
        public static void UpdateGroup(int GroupID, int CourseID)
        {
            string expr = string.Format("UPDATE Groups SET Groups.CourseID = {1} WHERE (((Groups.GroupID)={0}));", GroupID, CourseID);
            OledbHelper.Execute(expr);
        }
        #endregion
        #endregion
        #region Remove
        /// <summary>
        /// Removes The Specified Lesson From The Database
        /// </summary>
        /// <param name="LessonID"></param>
        public static void RemoveLesson(int LessonID)
        {
            string expr = String.Format("DELETE * FROM Lessons Where [LessonID]={0}", LessonID);
            OledbHelper.Execute(expr);
        }
        #endregion
        #endregion
    }
}

