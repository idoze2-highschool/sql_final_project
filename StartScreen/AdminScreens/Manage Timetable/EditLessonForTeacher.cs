using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GystClient.AdminScreens.Manage_Timetable
{
    public partial class EditLesson_ForTeacher : Form
    {
        private int Day, Period, TeacherID, GroupID, CourseID, SubjectID;
        private string TeacherName, GroupName;
        private Dictionary<int, int> CourseIndexToID, GroupIndexToID, SubjectIndexToID;
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
            GroupID = (int)TeacherToLesson["GroupID"];
            GroupName = (string)TeacherToLesson["GroupName"];
            SubjectID = (int)TeacherToLesson["SubjectID"];
            #endregion
            numericUpDown_grade.ValueChanged += (object sender, EventArgs e) => { LoadCourses(); };
            comboBox_Course.SelectedIndexChanged += (object sender, EventArgs e) => { LoadGroups(); };
            comboBox_Group.SelectedIndexChanged += (object sender, EventArgs e) => { LoadSubjects(); };
            button_edit.Click += (object sender, EventArgs e) =>
          {
              GroupID = GroupIndexToID[comboBox_Group.SelectedIndex];
              SubjectID = SubjectIndexToID[comboBox_Subject.SelectedIndex];
              DAL.UserMethods.UpdateLesson((int)TeacherToLesson["LessonID"], TeacherID, GroupID, SubjectID,Day,Period);
              Close();
          };
            button_cancel.Click += (object sender, EventArgs e) => 
            {
                Close();
            };
            #region Initialize Default Values For Editable Data
            LoadGrades();
            comboBox_Group.SelectedIndex = 0;
             #endregion
        }
        private void LoadSubjects()
        {
            SubjectIndexToID = new Dictionary<int, int>();
            DataRowCollection SubjectsToCourse = DAL.UserMethods.GetCourseAndTeacherToSubjects(CourseID,TeacherID);
            comboBox_Subject.Items.Clear();
            comboBox_Subject.Invalidate();
            foreach (DataRow Subject in SubjectsToCourse)
            {
                comboBox_Subject.Items.Add((string)Subject["SubjectName"]);
                SubjectIndexToID.Add(comboBox_Subject.Items.Count-1, (int)Subject["SubjectID"]);
                if (SubjectID == (int)Subject["SubjectID"])
                {
                    comboBox_Subject.SelectedIndex = comboBox_Subject.Items.Count-1;
                }
            }
        }
        private void LoadGroups()
        {
            GroupIndexToID = new Dictionary<int, int>();
            DataRowCollection GroupsToCourse = DAL.UserMethods.GetCourseToAvailableGroups(CourseID,Day,Period);
            comboBox_Group.Items.Clear();
            comboBox_Group.Invalidate();
            comboBox_Group.Items.Add(GroupName);
            GroupIndexToID.Add(0, GroupID);
            foreach (DataRow Group in GroupsToCourse)
            {
                comboBox_Group.Items.Add((string)Group["GroupName"]);
                GroupIndexToID.Add(comboBox_Group.Items.Count-1, (int)Group["GroupID"]);
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
                if (CourseID == (int)Course["CourseID"])
                    comboBox_Course.SelectedIndex = comboBox_Course.Items.Count - 1;
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
