using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Component.Data
{
    public class Subject
    {
        int id;
        string subjectName;
        public int ID { get => id; set => id = value; }
        public string SubjectName { get => subjectName; set => subjectName = value; }
        public Subject(int ID, string SubjectName)
        {
            this.ID = ID;
            this.SubjectName = SubjectName;
        }
        /// <summary>
        /// "Subjects"
        /// </summary>
        public static string Tablename { get => "Subjects"; }
        /// <summary>
        /// "SubjectID", "SubjectName"
        /// </summary>
        public static string[] Columns { get => new string[] { "SubjectsID", "SubjectsName" }; }
    }
}
