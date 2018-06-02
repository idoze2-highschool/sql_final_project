using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Components.Teacher_UI.Dashboard
{
    public partial class LandingPage : MetroFramework.Controls.MetroUserControl
    {
        public LandingPage()
        {
            InitializeComponent();
            label1.Text = string.Format("Welcome, {0}!\nHere's Your Timetable",Program.user.FName);
        }

        private void timetable1_Load(object sender, EventArgs e)
        {
            timetable1.AddLessons(DAL.Methods.GetLessonsByTeacher(Program.user.ID), "[SubjectName]");
        }
    }
}
