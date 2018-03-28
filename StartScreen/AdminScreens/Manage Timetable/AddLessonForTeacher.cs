using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL = DALOrg;

namespace GystClient.AdminScreens.Manage_Timetable
{
    public partial class AddLesson_ForTeacher : Form
    {
        private int Day, Period, TeacherID, GroupID, CourseID,Grade, SubjectID;
        private Dictionary<int, int> CourseIndexToID, GroupIndexToID, SubjectIndexToID;
        public AddLesson_ForTeacher(int Day, int Period, int TeacherID)
        {
            InitializeComponent();
            #region Hook Data Loading Queue
            numericUpDown_period.ValueChanged += (object sender, EventArgs e) => { this.Period = (int)numericUpDown_period.Value; CreateTeacherLabel(); LoadGrades(); };
            numericUpDown_grade.ValueChanged += (object sender, EventArgs e) => { Grade = (int)numericUpDown_grade.Value; LoadCourses(); };
            comboBox_Course.SelectedIndexChanged += (object sender, EventArgs e) => { CourseID = CourseIndexToID[comboBox_Course.SelectedIndex]; LoadGroups(); };
            comboBox_Group.SelectedIndexChanged += (object sender, EventArgs e) => { GroupID = GroupIndexToID[comboBox_Group.SelectedIndex]; LoadSubjects(); };
            #endregion
            button_add.Click += (object sender, EventArgs e) =>
            {
              GroupID = GroupIndexToID[comboBox_Group.SelectedIndex];
              SubjectID = SubjectIndexToID[comboBox_Subject.SelectedIndex];
              DAL.UserMethods.AddLesson( this.TeacherID, GroupID, SubjectID,this.Day,this.Period);
              Close();
          };
            button_cancel.Click += (object sender, EventArgs e) =>
            {
                Close();
            };
            #region Initialize Default Values
            this.Day = Day;
            CreateDayLabel();
            this.Period = Period;
            this.TeacherID = TeacherID;
            CreateTeacherLabel();
            numericUpDown_period.Value = this.Period;
            numericUpDown_period.Minimum = 1;
            #endregion
        }
        private void LoadGrades()
        {
            bool First = true;
            foreach (DataRow Course in DAL.UserMethods.GetCourseToTeacher(TeacherID))
            {
                int Grade = (int)Course["Grade"];
                if (First)
                {
                    numericUpDown_grade.Maximum = Grade;
                    numericUpDown_grade.Minimum = Grade;
                    First = false;
                }
                if (Grade > numericUpDown_grade.Maximum)
                    numericUpDown_grade.Maximum = Grade;
                else if (Grade < numericUpDown_grade.Minimum)
                    numericUpDown_grade.Minimum = Grade;
            }

        }
        private void LoadCourses()
        {
            CourseIndexToID = new Dictionary<int, int>();
            comboBox_Course.Items.Clear();
            comboBox_Course.Invalidate();
            foreach (DataRow Course in DAL.UserMethods.GetCourseToTeacher(TeacherID, (int)numericUpDown_grade.Value))
            {
             comboBox_Course.Items.Add((string)Course["CourseName"] + " Course");
             CourseIndexToID[comboBox_Course.Items.Count - 1] = (int)Course["CourseID"];
             comboBox_Course.SelectedIndex = 0;
            }
            comboBox_Course.SelectedIndex = 0;
        }
        private void LoadGroups()
        {
            GroupIndexToID = new Dictionary<int, int>();
            DataRowCollection GroupsToCourse = DAL.UserMethods.GetCourseToAvailableGroups(CourseID, Day, (int)numericUpDown_period.Value);
            comboBox_Group.Items.Clear();
            comboBox_Group.Invalidate();
            foreach (DataRow Group in GroupsToCourse)
            {
                comboBox_Group.Items.Add((string)Group["GroupName"]);
                GroupIndexToID.Add(comboBox_Group.Items.Count - 1, (int)Group["GroupID"]);
            }
            try
            {
                comboBox_Group.SelectedIndex = 0;
            }
            catch { button_add.Enabled = false; }
        }
        private void LoadSubjects()
        {
            SubjectIndexToID = new Dictionary<int, int>();
            DataRowCollection SubjectsToCourse = DAL.UserMethods.GetCourseAndTeacherToSubjects(CourseID, TeacherID);
            comboBox_Subject.Items.Clear();
            comboBox_Subject.Invalidate();
            foreach (DataRow Subject in SubjectsToCourse)
            {
                comboBox_Subject.Items.Add((string)Subject["SubjectName"]);
                SubjectIndexToID.Add(comboBox_Subject.Items.Count - 1, (int)Subject["SubjectID"]);
                if (SubjectID == (int)Subject["SubjectID"])
                {
                    comboBox_Subject.SelectedIndex = comboBox_Subject.Items.Count - 1;
                }
            }
            comboBox_Subject.SelectedIndex = 0;
        }
        private void CreateDayLabel()
        {
            //Insert Day Data
            Controls.Add(new Label()
            {
                Name = "label_day",
                ForeColor = Color.Blue,
                AutoSize = true,
                TabIndex = 0,
                Location = new Point(label_day_title.Size.Width + label_day_title.Location.X, label_day_title.Location.Y),
                Text = Methods.GetDayName(Day),
                TextAlign = ContentAlignment.MiddleCenter
            });
        }
        private void CreateTeacherLabel()
        {
            Controls.RemoveByKey("label_teacher");
            //Insert Teacher Data
           Label l = new Label()
           {
               Name = "label_teacher",
               ForeColor = Color.Blue,
               AutoSize = true,
               TabIndex = 0,
               Location = new Point(label_teacher_title.Size.Width + label_teacher_title.Location.X, label_teacher_title.Location.Y),
               Text = DAL.UserMethods.GetNameOfUser(TeacherID),
               TextAlign = ContentAlignment.MiddleCenter
           };
            if (!DAL.UserMethods.IsTeacherAvailable(TeacherID, Day, Period))
            {
                l.ForeColor = Color.Red;
                button_add.Enabled = false;
            }
            else
            {
                l.ForeColor = Color.Blue;
                button_add.Enabled = true;
            }
            Controls.Add(l);
        }
    }
}
