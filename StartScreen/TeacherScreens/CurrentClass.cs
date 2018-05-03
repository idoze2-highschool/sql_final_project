using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GystClient.TeacherScreens
{
    public partial class CurrentClass : Form
    {
        private List<int> AbsentStudentIDs;
        public CurrentClass()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            AbsentStudentIDs = new List<int>();
            //DataRowCollection DRs = DAL.UserMethods.GetStudents(int.Parse(DAL.UserMethods.GetCurrentLesson(Program.user.ID)["GroupID"].ToString()));
            DataRowCollection DRs = DAL.UserMethods.GetStudentsOfGroup(1);
            int x =0 , y = 0;
            foreach (DataRow Student in DRs)
            {
                Label s = new Label();
                s.Tag = false;
                s.Text = Student["FName"] + " " + Student["LName"];
                s.Click += (Object, EventArgs) =>
                  {
                      s.Tag = !(bool)s.Tag;
                      if ((bool)s.Tag)
                      {
                          s.BackColor = Color.Red;
                          AbsentStudentIDs.Add(int.Parse(Student["UserID"].ToString()));
                      }
                      else
                      {
                          s.BackColor = Color.Transparent;
                          AbsentStudentIDs.Remove(int.Parse(Student["UserID"].ToString()));
                      }
                  };
                s.Location = new Point(x, y);
                Panel_Lable_StudentNames.Controls.Add(s);
                y += s.Height;
                

            }
        }
    }
}
