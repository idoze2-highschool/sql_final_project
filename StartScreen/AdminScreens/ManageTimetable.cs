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
    public partial class ManageTimetable : Form
    {
        public ManageTimetable()
        {
            InitializeComponent();
            LoadTree();
            LoadTimeTable_Base();
        }
        #region Tree Building
        public void LoadTree()
        {
            treeView_Search.Nodes.Add(GetTree_Teachers());
            treeView_Search.Nodes.Add(GetTree_Groups());
            treeView_Search.NodeMouseDoubleClick += (object sender, TreeNodeMouseClickEventArgs e) =>
              {
                  TreeNode Selection = ((TreeView)sender).SelectedNode;
                  string _Name = Selection.Name.ToString();
                  try
                  {
                      int _ID = int.Parse(_Name.Substring(_Name.IndexOf(":") + 1));
                      switch (_Name.Substring(0, _Name.IndexOf(':')))
                      {
                          case "Teacher":
                              LoadTimeTable_ByTeacher(_ID);
                              break;
                          case "Group":
                              LoadTimeTable_ByGroup(_ID);
                              break;
                      }
                  }
                  catch { }
              };
        }
        #region Get Tree Methods
        private TreeNode GetTree_Teachers()
        {
            TreeNode Root = new TreeNode()
            {
                Name = "Teachers",
            };
            foreach (DataRow Teacher in DAL.UserMethods.GetTeachers())
            {
                string FName = Teacher["FName"].ToString();
                string LName = Teacher["LName"].ToString();
                string ID = Teacher["UserID"].ToString();
                TreeNode TeacherNode = new TreeNode(FName + " " + LName) { Name = string.Format("Teacher:{0}", ID) };
                Root.Nodes.Add(TeacherNode);
            }
            Root.Text = string.Format("Teachers [{0}]", Root.Nodes.Count);
            return Root;
        }
        private TreeNode GetTree_Groups()
        {
            int GroupCount = 0;
            TreeNode Root = new TreeNode(){ Name = "Groups" };
            foreach (DataRow Student in DAL.UserMethods.GetCourseToGroup())
            {
                string Grade = (Student["Grade"]).ToString();
                string Course = (Student["CourseName"]).ToString();
                string Group = (Student["GroupName"]).ToString();
                TreeNode GradeNode = new TreeNode(Methods.ToIndexingNumber(int.Parse(Grade)) + " Grade") { Name = Grade, Tag = "Grade:" + Grade };
                TreeNode CourseNode = new TreeNode(Course + " Course") { Name = Course, Tag = "Course:" + Course };
                TreeNode GroupNode = new TreeNode(Group) { Name = string.Format("Group:{0}", Student["GroupID"]) };
                if (Root.Nodes.ContainsKey(Grade))
                {
                    GradeNode = Root.Nodes.Find(Grade, false)[0];
                    if (GradeNode.Nodes.ContainsKey(Course))
                    {
                        CourseNode = GradeNode.Nodes.Find(Course, false)[0];
                        if (!CourseNode.Nodes.ContainsKey(GroupNode.Name))
                        {
                            CourseNode.Nodes.Add(GroupNode);
                            GroupCount++;
                        }
                    }
                    else
                    {
                        CourseNode.Nodes.Add(GroupNode);
                        GroupCount++;
                        GradeNode.Nodes.Add(CourseNode);
                    }
                }
                else
                {
                    CourseNode.Nodes.Add(GroupNode);
                    GroupCount++;
                    GradeNode.Nodes.Add(CourseNode);
                    Root.Nodes.Add(GradeNode);
                }
            }
            Root.Text = string.Format("Groups [{0}]", GroupCount);
            return Root;
        }
        #endregion
        #endregion
        #region TimeTable Building
        public void LoadTimeTable_Base()
        {
            panel_table.Controls.Clear();
            panel_table.Controls.AddRange(GetTimeTableBase().ToArray());
        }
        public void LoadTimeTable_ByTeacher(int TeacherID)
        {
            panel_table.Controls.Clear();
            panel_table.Controls.AddRange(GetTimeTableByTeacher(TeacherID).ToArray());
            treeView_Search.CollapseAll();
            TreeNode Selection = treeView_Search.Nodes.Find(String.Format("Teacher:{0}", TeacherID), true)[0];
            treeView_Search.SelectedNode = Selection;
        }
        public void LoadTimeTable_ByGroup(int GroupID)
        {
            panel_table.Controls.Clear();
            panel_table.Controls.AddRange(GetTimeTableByGroup(GroupID).ToArray());
            treeView_Search.CollapseAll();
            TreeNode Selection = treeView_Search.Nodes.Find(String.Format("Group:{0}", GroupID), true)[0];
            treeView_Search.SelectedNode = Selection;
        }
        #region TimeTable Base
        public List<Control> GetTimeTableBase(Size LabelSize, Color DefaultBackColor)
        {
            List<Control> ControlList = new List<Control>();
            for (int day = 1; day < 7; day++)
            {
                string DayName = Methods.GetDayName(day);
                Label l = new Label
                {
                    Name = "label_" + DayName,
                    BackColor = DefaultBackColor,
                    BorderStyle = BorderStyle.FixedSingle,
                    ForeColor = SystemColors.ControlText,
                    Size = LabelSize,
                    TabIndex = 0,
                    Text = DayName.Substring(0, 3),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                l.Location = new Point(l.Size.Width * (day - 1), 0);
                ControlList.Add(l);
                for (int period = 1; period < 11; period++)
                {
                    l = new Label
                    {
                        Name = "label_" + day + "_" + period,
                        Text = Methods.ToIndexingNumber(period) + " Period",
                        BackColor = DefaultBackColor,
                        BorderStyle = BorderStyle.FixedSingle,
                        ForeColor = SystemColors.ControlText,
                        Size = LabelSize,
                        TabIndex = 0,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Tag = new Tuple<int, int>(day, period)
                    };
                    l.Location = new Point(l.Size.Width * (day - 1), l.Size.Height * period);
                    l.MouseEnter += (object _sender, EventArgs _e) =>
                    {
                        ((Control)_sender).BackColor = Color.FromArgb(((Control)_sender).BackColor.A / 2, ((Control)_sender).BackColor);
                    };
                    l.MouseLeave += (object _sender, EventArgs _e) =>
                    {
                        try
                        {
                            ((Control)_sender).BackColor = Color.FromArgb(((Control)_sender).BackColor.A * 2, ((Control)_sender).BackColor);
                        }
                        catch { }
                    };
                    ControlList.Add(l);
                };
            }
            return ControlList;
        }
        public List<Control> GetTimeTableBase()
        {
            return GetTimeTableBase(new Size(80, 30), Color.White);
        }
        #endregion
        #region TimeTable By Filter
        public List<Control> GetTimeTableByTeacher(int TeacherID)
        {
            List<Control> TableControls = GetTimeTableBase(new Size(100, 40), Color.White);
            foreach (DataRow TeacherToLesson in DAL.UserMethods.GetLessonsByTeacher(TeacherID))
            {

                int index = TableControls.FindIndex(c => c.Name == "label_" + TeacherToLesson["Day"] + "_" + TeacherToLesson["Period"]);
                TableControls[index].Text = TeacherToLesson["SubjectName"] + "\nWith:" + TeacherToLesson["GroupName"];
                TableControls[index].BackColor = Color.Gray;
                #region Create ContextMenu
                ContextMenu menu = new ContextMenu();
                MenuItem ViewGroup = new MenuItem()
                {
                    Name = "menuItem_Group",
                    Text = string.Format("View Table For Group: {0}", TeacherToLesson["GroupName"]),
                    Tag = TeacherToLesson["GroupID"].ToString(),
                    BarBreak = true
                };
                ViewGroup.Click += (object _sender, EventArgs _e) => { LoadTimeTable_ByGroup(int.Parse((string)ViewGroup.Tag)); };
                MenuItem Edit = new MenuItem()
                {
                    Name = "menuItem_Edit",
                    Text = string.Format("Edit"),
                    Tag = TeacherToLesson,
                };
                Edit.Click += (object _sender, EventArgs _e) =>
                {
                    EditLesson_ForTeacher form = new EditLesson_ForTeacher((DataRow)((MenuItem)_sender).Tag);
                    form.Show();
                    
                };
                MenuItem Remove = new MenuItem()
                {
                    Name = "menuItem_Remove",
                    Text = string.Format("Remove"),
                    Tag = TeacherToLesson["LessonID"].ToString(),
                };
                Remove.Click += menuItem_Remove_Click;
                menu.MenuItems.AddRange(new MenuItem[] { ViewGroup, Edit, Remove });
                TableControls[index].ContextMenu = menu;
                #endregion
            }
            return TableControls;
        }
        public List<Control> GetTimeTableByGroup(int GroupID)
        {
            List<Control> TableControls = GetTimeTableBase(new Size(70, 30), Color.White);
            foreach (DataRow Lesson in DAL.UserMethods.GetLessonsByGroup(GroupID))
            {
                int index = TableControls.FindIndex(c => c.Name == "label_" + Lesson["Day"] + "_" + Lesson["Period"]);
                TableControls[index].Text = Lesson["SubjectName"] + "\nWith:" + Lesson["TeacherName"];
                TableControls[index].BackColor = Color.Gray;
                #region Create ContextMenu
                ContextMenu menu = new ContextMenu();
                MenuItem ViewTeacher = new MenuItem()
                {
                    Name = "menuItem_Teacher",
                    Text = string.Format("View Table For Teacher: {0}", Lesson["TeacherName"]),
                    Tag = Lesson["TeacherID"].ToString(),
                    BarBreak = true
                };
                ViewTeacher.Click += (object _sender, EventArgs _e) => { LoadTimeTable_ByTeacher(int.Parse((string)ViewTeacher.Tag)); };
                MenuItem Edit = new MenuItem()
                {
                    Name = "menuItem_Edit",
                    Text = string.Format("Edit"),
                    Tag = Lesson["LessonID"].ToString(),
                };
                Edit.Click += menuItem_Edit_Click;
                MenuItem Remove = new MenuItem()
                {
                    Name = "menuItem_Remove",
                    Text = string.Format("Remove"),
                    Tag = Lesson["LessonID"].ToString(),
                };
                Remove.Click += menuItem_Remove_Click;
                menu.MenuItems.AddRange(new MenuItem[] { ViewTeacher, Edit, Remove });
                TableControls[index].ContextMenu = menu;
                #endregion
            }
            return TableControls;
        }
        #endregion

        private void menuItem_Remove_Click(object sender, EventArgs e)
        {
            int ID = (int.Parse(((MenuItem)sender).Tag.ToString()));
            DialogResult MsgBoxResult = MessageBox.Show(String.Format("Are You Sure You Would Like To\nRemove Lesson With ID: {0}?", ID), "Confirm", MessageBoxButtons.YesNo);
            if ((int)MsgBoxResult == 6)
                DAL.UserMethods.RemoveLesson(ID);
        }
        private void menuItem_Edit_Click(object sender, EventArgs e)
        {
            
            
        }
        #endregion
    }
}