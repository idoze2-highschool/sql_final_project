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
    public partial class AddLesson_ForGroup : Form
    {
        private int Day, Period, TeacherID, GroupID, CourseID, SubjectID, Grade;
        private string CourseName, GroupName;
        private Dictionary<int, int> TeacherIndexToID, SubjectIndexToID;
        public AddLesson_ForGroup(int Day, int Period, int GroupID)
        {
            InitializeComponent();
            #region Hook Data Loading Queue
            numericUpDown_period.ValueChanged += (object sender, EventArgs e) => { this.Period = (int)numericUpDown_period.Value;CreateGroupLabel(); LoadTeachers(); };
            comboBox_Teacher.SelectedIndexChanged += (object sender, EventArgs e) => { TeacherID = TeacherIndexToID[comboBox_Teacher.SelectedIndex]; LoadSubjects(); };
            #endregion
            button_add.Click += (object sender, EventArgs e) =>
          {
              SubjectID = SubjectIndexToID[comboBox_Subject.SelectedIndex];
              DAL.UserMethods.AddLesson(TeacherID, this.GroupID, SubjectID, this.Day, this.Period);
              Close();
          };
            button_cancel.Click += (object sender, EventArgs e) =>
            {
                Close();
            };
            #region Initialize Default Values For Editable Data
            this.Day = Day;
            CreateDayLabel();
            this.Period = Period;
            this.GroupID = GroupID;
            DataRow Course = DAL.UserMethods.GetCourseOfGroup(GroupID);
            CourseID = (int)Course["CourseID"];
            CourseName = (string)Course["CourseName"];
            CreateCourseLabel();
            Grade = (int)Course["Grade"];
            CreateGradeLabel();
            GroupName = DAL.UserMethods.GetGroupName(GroupID);
            CreateGroupLabel();
            numericUpDown_period.Value = this.Period;
            numericUpDown_period.Minimum = 1;
            #endregion
        }
        private void LoadTeachers()
        {
            TeacherIndexToID = new Dictionary<int, int>();
            DataRowCollection AvailableTeachers = DAL.UserMethods.GetCourseToAvailableTeachers(Day, Period, CourseID);
            comboBox_Teacher.Items.Clear();
            comboBox_Teacher.Invalidate();
            foreach (DataRow Teacher in AvailableTeachers)
            {
                comboBox_Teacher.Items.Add((string)Teacher["Name"]);
                TeacherIndexToID.Add(comboBox_Teacher.Items.Count - 1, (int)Teacher["TeacherID"]);
            }
            try
            {
                comboBox_Teacher.SelectedIndex = 0;
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
        private void CreateCourseLabel()
        {
            //Insert Day Data
            Controls.Add(new Label()
            {
                Name = "label_Course",
                ForeColor = Color.Blue,
                AutoSize = true,
                TabIndex = 0,
                Location = new Point(label_course_title.Size.Width + label_course_title.Location.X, label_course_title.Location.Y),
                Text = CourseName,
                TextAlign = ContentAlignment.MiddleCenter
            });
        }
        private void CreateGradeLabel()
        {
            //Insert Day Data
            Controls.Add(new Label()
            {
                Name = "label_Grade",
                ForeColor = Color.Blue,
                AutoSize = true,
                TabIndex = 0,
                Location = new Point(label_grade_title.Size.Width + label_grade_title.Location.X, label_grade_title.Location.Y),
                Text = Grade.ToString(),
                TextAlign = ContentAlignment.MiddleCenter
            });
        }
        private void CreateGroupLabel()
        {
            Controls.RemoveByKey("label_Group");
            //Insert Day Data
            Label l = new Label()
            {
                Name = "label_Group",
                ForeColor = Color.Blue,
                AutoSize = true,
                TabIndex = 0,
                Location = new Point(label_group_title.Size.Width + label_group_title.Location.X, label_group_title.Location.Y),
                Text = GroupName,
                TextAlign = ContentAlignment.MiddleCenter
            };
            if (!DAL.UserMethods.IsGroupAvailable(GroupID,Day, Period))
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
