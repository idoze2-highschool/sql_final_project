using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Component.Data
{
    public class Course
    {
        int id, grade;
        string courseName;
        public int ID { get => id; set => id = value; }
        public int Grade { get => grade; set => grade = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public Course(int ID,string CourseName, int Grade)
        {
            this.ID = ID;
            this.CourseName = CourseName;
            this.Grade = Grade;
        }
        /// <summary>
        /// "Courses"
        /// </summary>
        public static string Tablename { get => "Courses"; }
        /// <summary>
        /// "CourseID", "CourseName", "Grade" 
        /// </summary>
        public static string[] Columns { get => new string[] { "CourseID", "CourseName", "Grade" }; }


    }
}
