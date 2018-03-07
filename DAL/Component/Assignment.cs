using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Component
{
    class Assignment:Component
    {
        public Group Group;
        public string AssTitle;
        public string AssDesc;
        public Lesson Due;
        public Assignment(int AssignmentID,Group Group,string Title,string Desc,Lesson DueLesson):base(AssignmentID)
        {

        }
    }
}
