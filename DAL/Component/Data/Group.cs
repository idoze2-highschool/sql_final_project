using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Component.Data
{
    class Group
    {
        int id, courseID;
        string groupName;
        public int ID { get => id; set => id = value; }
        public int CourseID { get => courseID; set => courseID = value; }
        public string GroupName { get => groupName; set => groupName = value; }
        public Group(int ID, string GroupName, int CourseID)
        {
            this.ID = ID;
            this.GroupName = GroupName;
            this.CourseID = CourseID;
        }
        /// <summary>
        /// "Groups"
        /// </summary>
        public static string Tablename { get => "Groups"; }
        /// <summary>
        /// "GroupID", "GroupName", "CourseID" 
        /// </summary>
        public static string[] Columns { get => new string[] { "GroupID", "GroupName", "CourseID" }; }
    }
}
