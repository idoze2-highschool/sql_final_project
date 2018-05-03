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
    public partial class EditLesson_ForGroup : Form
    {
        private int Day, Period, TeacherID, GroupID, CourseID, SubjectID, Grade;
        private string TeacherName,CourseName, GroupName;
        private Dictionary<int, int> TeacherIndexToID ,SubjectIndexToID;
        public EditLesson_ForGroup(DataRow Lesson)
        {
            InitializeComponent();
            #region Insert Locked Data
            Day = (int)Lesson["Day"];
            CreateDayLabel();
            Period = (int)Lesson["Period"];
            CreatePeriodLabel();
            CourseName = (string)Lesson["CourseName"];
            CourseID = (int)Lesson["CourseID"];
            CreateCourseLabel();
            GroupID = (int)Lesson["GroupID"];
            GroupName = (string)Lesson["GroupName"];
            CreateGroupLabel();
            Grade = (int)Lesson["Grade"];
            CreateGradeLabel();
            SubjectID = (int)Lesson["SubjectID"];
            TeacherID = (int)Lesson["TeacherID"];
            TeacherName = (string)Lesson["TeacherName"];
            #endregion
            comboBox_Teacher.SelectedIndexChanged += (object sender, EventArgs e) => { TeacherID = TeacherIndexToID[comboBox_Teacher.SelectedIndex]; LoadSubjects(); };
            button_edit.Click += (object sender, EventArgs e) =>
          {
              TeacherID = TeacherIndexToID[comboBox_Teacher.SelectedIndex];
              SubjectID = SubjectIndexToID[comboBox_Subject.SelectedIndex];
              DAL.UserMethods.UpdateLesson((int)Lesson["LessonID"], TeacherID, GroupID, SubjectID,Day,Period);
              Close();
          };
            button_cancel.Click += (object sender, EventArgs e) => 
            {
                Close();
            };
            #region Initialize Default Values For Editable Data
            LoadTeachers();
            comboBox_Teacher.SelectedIndex = 0;
             #endregion
        }
        private void LoadTeachers()
        {
            TeacherIndexToID = new Dictionary<int, int>();
            DataRowCollection AvailableTeachers = DAL.UserMethods.GetCourseToAvailableTeachers(Day,Period,CourseID);
            comboBox_Teacher.Items.Clear();
            comboBox_Teacher.Invalidate();
            comboBox_Teacher.Items.Add(TeacherName);
            TeacherIndexToID.Add(0, TeacherID);
            foreach (DataRow Teacher in AvailableTeachers)
            {
                comboBox_Teacher.Items.Add((string)Teacher["Name"]);
                TeacherIndexToID.Add(comboBox_Teacher.Items.Count - 1, (int)Teacher["TeacherID"]);

            }
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
            //Insert Day Data
            Controls.Add(new Label()
            {
                Name = "label_Grade",
                ForeColor = Color.Blue,
                AutoSize = true,
                TabIndex = 0,
                Location = new Point(label_group_title.Size.Width + label_group_title.Location.X, label_group_title.Location.Y),
                Text = GroupName,
                TextAlign = ContentAlignment.MiddleCenter
            });
        }
    }
}
