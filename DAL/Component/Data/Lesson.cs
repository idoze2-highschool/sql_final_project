using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Component.Data
{
    public class Lesson
    {
        private int id, groupID, teacherID, subjectID, day, period;
        public int ID { get => id; set => id = value; }
        public int GroupID { get => groupID; set => groupID = value; }
        public int TeacherID { get => teacherID; set => teacherID = value; }
        public int SubjectID { get => subjectID; set => subjectID = value; }
        public int Day { get => day; set => day = value; }
        public int Period { get => period; set => period = value; }
        public Lesson(int ID, int GroupID, int TeacherID, int SubjectID, int Day, int Period)
        {
            this.ID = ID;
            this.GroupID = GroupID;
            this.TeacherID = TeacherID;
            this.SubjectID = SubjectID;
            this.Day = Day;
            this.Period = Period;
        }
        /// <summary>
        /// "Lessons"
        /// </summary>
        public static string Tablename { get => "Lessons"; }
        /// <summary>
        /// "LessonID", "GroupID", "TeacherID", "SubjectID", "Day", "Period"
        /// </summary>
        public static string[] Columns { get => new string[] { "LessonID", "GroupID", "TeacherID", "SubjectID", "Day", "Period" }; }
    }
}
