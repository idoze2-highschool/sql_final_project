using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Components.Admin_UI.Users.Timetables
{
    public partial class Teacher : MetroFramework.Controls.MetroUserControl
    {
        private int TeacherID = 0;
        public Teacher():this(0)
        {   
        }
        public Teacher(int TeacherID)
        {
            this.TeacherID = TeacherID;
            InitializeComponent();
            LoadTimetable();
        }
        public void LoadTimetable()
        {
            timetable_main.AddLessons(DAL.Methods.GetLessonsByTeacher(TeacherID),"[SubjectName]");
        }
    }
}
