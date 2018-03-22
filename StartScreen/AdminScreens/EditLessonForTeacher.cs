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

namespace GystClient.AdminScreens
{
    public partial class EditLesson_ForTeacher : Form
    {
        private int Day, Period, TeacherID, GroupID, CourseID, SubjectID;
        private string TeacherName;
        private Dictionary<int, int> CourseIndexToID, GroupIndexToID;
        public EditLesson_ForTeacher(DataRow TeacherToLesson)
        {
            InitializeComponent();
            #region Insert Locked Data
            Day = (int)TeacherToLesson["Day"];
            CreateDayLabel();
            Period = (int)TeacherToLesson["Period"];
            CreatePeriodLabel();
            TeacherID = (int)TeacherToLesson["TeacherID"];
            this.TeacherName = String.Format("{0} {1}", TeacherToLesson["TeacherFName"], TeacherToLesson["TeacherLName"]);
            CreateTeacherLabel();
            CourseID = (int)TeacherToLesson["CourseID"];
            #endregion
            numericUpDown_grade.ValueChanged += (object sender, EventArgs e) => { LoadCourses(); };
            comboBox_Course.SelectedIndexChanged += (object sender, EventArgs e) => { insertGroups(); };
            #region Initialize Default Values For Editable Data
            LoadGrades();
            #endregion
        }
        private void insertGroups()
        {
            GroupIndexToID = new Dictionary<int, int>();
            DataRowCollection GroupsToCourse = DAL.UserMethods.GetCourseToAvailableGroups(CourseID,Day,Period);
            comboBox_Group.Items.Clear();
            comboBox_Group.Invalidate();
            foreach (DataRow Group in GroupsToCourse)
            {
                comboBox_Group.Items.Add((string)Group["GroupName"]);
                GroupIndexToID.Add(comboBox_Group.Items.Count, (int)Group["GroupID"]);
                if (GroupID == (int)Group["GroupID"])
                {
                    comboBox_Group.SelectedIndex = comboBox_Group.Items.Count;
                }
            }
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
                if (CourseID == (int)Course["CourseID"])
                    numericUpDown_grade.Value = Grade;
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
            }
        }
        private void CreateTeacherLabel()
        {
            //Insert Teacher Data
            Controls.Add(new Label()
            {
                Name = "label_teacher",
                ForeColor = Color.Blue,
                AutoSize = true,
                TabIndex = 0,
                Location = new Point(label_teacher_title.Size.Width + label_teacher_title.Location.X, label_teacher_title.Location.Y),
                Text = TeacherName,
                TextAlign = ContentAlignment.MiddleCenter
            });
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
        private void CreatePeriodLabel()
        {
            //Insert Period Data
            Controls.Add(new Label()
            {
                Name = "label_period",
                ForeColor = Color.Blue,
                AutoSize = true,
                TabIndex = 0,
                Location = new Point(label_period_title.Size.Width + label_period_title.Location.X, label_period_title.Location.Y),
                Text = Methods.ToIndexingNumber(Period),
                TextAlign = ContentAlignment.MiddleCenter
            });
        }
    }
}
