using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Component.Data
{
    public class Assignment
    {
        int id, teacherID, subjectID, groupID;
        string assTitle, assDesc;
        DateTime dateTime;
        public int ID { get => id; set => id = value; }
        public int TeacherID { get => teacherID; set => teacherID = value; }
        public int SubjectID { get => subjectID; set => subjectID = value; }
        public int GroupID { get => groupID; set => groupID = value; }
        public string AssTitle { get => assTitle; set => assTitle = value; }
        public string AssDesc { get => assDesc; set => assDesc = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public Assignment(int ID, int TeacherID, int SubjectID, int GroupID, string AssTitle, string AssDesc, DateTime DateTime)
        {
            this.ID = ID;
            this.TeacherID = TeacherID;
            this.SubjectID = SubjectID;
            this.GroupID = GroupID;
            this.AssTitle = AssTitle;
            this.AssDesc = AssDesc;
            this.DateTime = DateTime;
        }
        /// <summary>
        /// "Assignments"
        /// </summary>
        public static string Tablename { get => "Assignments"; }
        /// <summary>
        /// "AssignmentID", "AssTitle", "AssDesc", "DateTime"
        /// </summary>
        public static string[] Columns { get => new string[] { "AssignmentID", "AssTitle", "AssDesc", "DateTime" }; }

    }
}
