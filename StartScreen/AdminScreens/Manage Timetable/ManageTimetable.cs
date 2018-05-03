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
                  catch
                  {
                      //throw;
                  }
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
            TreeNode Root = new TreeNode() { Name = "Groups" };
            foreach (DataRow Group in DAL.UserMethods.GetCourseToGroup())
            {
                string Grade = (Group["Grade"]).ToString();
                string CourseName = (Group["CourseName"]).ToString();
                string GroupName = (Group["GroupName"]).ToString();
                TreeNode GradeNode = new TreeNode(Methods.ToIndexingNumber(int.Parse(Grade)) + " Grade") { Name = Grade, Tag = "Grade:" + Grade };
                TreeNode CourseNode = new TreeNode(CourseName + " Course") { Name = CourseName, Tag = "Course:" + CourseName };
                TreeNode GroupNode = new TreeNode(GroupName) { Name = string.Format("Group:{0}", Group["GroupID"]) };
                if (Root.Nodes.ContainsKey(Grade))
                {
                    GradeNode = Root.Nodes.Find(Grade, false)[0];
                    if (GradeNode.Nodes.ContainsKey(CourseName))
                    {
                        CourseNode = GradeNode.Nodes.Find(CourseName, false)[0];
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
        #region TimeTable Base
        public List<Control> GetTimeTableBase()
        {
            List<Control> ControlList = new List<Control>();
            Size LabelSize = new Size(100, 40);
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
            }
            return ControlList;
        }
        #endregion
        public void LoadTimeTable_ByTeacher(int TeacherID)
        {
            LoadTimeTable_Base();
            panel_table.Controls.AddRange(GetTimeTableByTeacher(TeacherID).ToArray());
            treeView_Search.CollapseAll();
            TreeNode Selection = treeView_Search.Nodes.Find(String.Format("Teacher:{0}", TeacherID), true)[0];
            treeView_Search.SelectedNode = Selection;
        }
        public void LoadTimeTable_ByGroup(int GroupID)
        {
            LoadTimeTable_Base();
            panel_table.Controls.AddRange(GetTimeTableByGroup(GroupID).ToArray());
            treeView_Search.CollapseAll();
            TreeNode Selection = treeView_Search.Nodes.Find(String.Format("Group:{0}", GroupID), true)[0];
            treeView_Search.SelectedNode = Selection;
        }
        #region TimeTable By Filter
        public List<Label> GetTimeTableByTeacher(int TeacherID)
        {
            Size LabelSize = new Size(100, 40);
            List<Label> ControlList = new List<Label>();
            foreach (DataRow Lesson in DAL.UserMethods.GetLessonsByTeacher(TeacherID))
            {
                Label l = new Label()
                {
                    Name = "label_" + Lesson["Day"] + "_" + Lesson["period"],
                    Text = Lesson["SubjectName"] + "\nWith:" + Lesson["GroupName"],
                    BackColor = Color.DimGray,
                    BorderStyle = BorderStyle.FixedSingle,
                    ForeColor = SystemColors.ControlText,
                    Size = LabelSize,
                    TabIndex = 0,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = new Tuple<int, int>((int)Lesson["Day"], (int)Lesson["Period"])
                };
                l.Location = new Point(l.Size.Width * ((int)Lesson["Day"] - 1), l.Size.Height * (int)Lesson["period"]);
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
                #region Create ContextMenu
                ContextMenu menu = new ContextMenu();
                MenuItem ViewGroup = new MenuItem()
                {
                    Name = "menuItem_Group",
                    Text = string.Format("View Table For Group: {0}", Lesson["GroupName"]),
                    Tag = Lesson["GroupID"].ToString(),
                    BarBreak = true
                };
                ViewGroup.Click += (object _sender, EventArgs _e) => { LoadTimeTable_ByGroup(int.Parse((string)ViewGroup.Tag)); };
                MenuItem Edit = new MenuItem()
                {
                    Name = "menuItem_Edit",
                    Text = string.Format("Edit"),
                    Tag = Lesson,
                };
                Edit.Click += (object _sender, EventArgs _e) =>
                {
                    EditLesson_ForTeacher form = new EditLesson_ForTeacher((DataRow)((MenuItem)_sender).Tag);
                    form.FormClosed += (object __sender, FormClosedEventArgs __e) => { LoadTimeTable_ByTeacher(TeacherID); };
                    form.Show();

                };
                MenuItem Remove = new MenuItem()
                {
                    Name = "menuItem_Remove",
                    Text = string.Format("Remove"),
                    Tag = Lesson["LessonID"].ToString(),
                };
                Remove.Click += (object sender, EventArgs e) =>
        {
            int ID = (int.Parse(((MenuItem)sender).Tag.ToString()));
            DialogResult MsgBoxResult = MessageBox.Show(String.Format("Are You Sure You Would Like To\nRemove Lesson With ID: {0}?", ID), "Confirm", MessageBoxButtons.YesNo);
            if ((int)MsgBoxResult == 6)
                DAL.UserMethods.RemoveLesson(ID);
        };
                Remove.Click += (object __sender, EventArgs __e) => { LoadTimeTable_ByTeacher(TeacherID); };
                menu.MenuItems.AddRange(new MenuItem[] { ViewGroup, Edit, Remove });
                l.ContextMenu = menu;
                #endregion
                #region Handle Gaps
                Label LastControl = new Label() { Tag = new Tuple<int, int>((int)Lesson["Day"], 0) };
                try { LastControl = ControlList.Last(c => ((Tuple<int, int>)c.Tag).Item1 == (int)Lesson["Day"]); }
                catch { }
                Tuple<int, int> Last = (Tuple<int, int>)LastControl.Tag;
                #region Add FreePeriods
                for (int period = Last.Item2 + 1; (period < (int)Lesson["Period"]); period++)
                {
                    Label w = new Label()
                    {
                        Name = "label_" + Lesson["Day"] + "_" + period,
                        Text = "Unassigned",
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.FixedSingle,
                        ForeColor = SystemColors.ControlText,
                        Size = LabelSize,
                        TabIndex = 0,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Tag = new Tuple<int, int>(Last.Item1, period)
                    };
                    w.Location = new Point(w.Size.Width * ((int)Lesson["Day"] - 1), w.Size.Height * period);
                    w.MouseEnter += (object _sender, EventArgs _e) =>
                    {
                        ((Control)_sender).BackColor = Color.FromArgb(((Control)_sender).BackColor.A / 2, ((Control)_sender).BackColor);
                        ((Label)(Control)_sender).Text = "+";
                    };
                    w.MouseLeave += (object _sender, EventArgs _e) =>
                    {
                        try
                        {
                            ((Control)_sender).BackColor = Color.FromArgb(((Control)_sender).BackColor.A * 2, ((Control)_sender).BackColor);
                        }
                        catch { }
                        ((Label)(Control)_sender).Text = "Unassigned";
                    };
                    w.Click += (object _sender, EventArgs _e) =>
                    {
                        AddLesson_ForTeacher AddLesson = new AddLesson_ForTeacher(((Tuple<int, int>)w.Tag).Item1, ((Tuple<int, int>)w.Tag).Item2, TeacherID);
                        AddLesson.Closed += (object __sender, EventArgs __e) => { LoadTimeTable_ByTeacher(TeacherID); };
                        AddLesson.Show();
                    };
                    ControlList.Add(w);
                }
                #endregion
                #endregion
                ControlList.Add(l);
            }
            #region Create AddLesson in every day's last slot
            for (int day = 0; day < 7; day++)
            {
                Tuple<int, int> Last = new Tuple<int, int>(day, 0);
                try { Last = (Tuple<int, int>)ControlList.Last(c => ((Tuple<int, int>)c.Tag).Item1 == day).Tag; }
                catch { }
                Label Add = new Label()
                {
                    Name = "label_" + Last.Item1 + "_" + Last.Item2 + 1,
                    Text = " ",
                    BackColor = Color.Transparent,
                    BorderStyle = BorderStyle.FixedSingle,
                    ForeColor = SystemColors.ControlText,
                    Size = LabelSize,
                    TabIndex = 0,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = new Tuple<int, int>(Last.Item1, Last.Item2 + 1)
                };
                Add.Location = new Point(Add.Size.Width * (Last.Item1 - 1), Add.Size.Height * (Last.Item2 + 1));
                Add.MouseEnter += (object _sender, EventArgs _e) =>
                {
                    ((Control)_sender).BackColor = Color.FromArgb(((Control)_sender).BackColor.A / 2, ((Control)_sender).BackColor);
                    ((Label)(Control)_sender).Text = "+";
                };
                Add.MouseLeave += (object _sender, EventArgs _e) =>
                {
                    try
                    {
                        ((Control)_sender).BackColor = Color.FromArgb(((Control)_sender).BackColor.A * 2, ((Control)_sender).BackColor);
                    }
                    catch { }
                    ((Label)(Control)_sender).Text = " ";
                };
                Add.Click += (object _sender, EventArgs _e) =>
                {
                    AddLesson_ForTeacher AddLesson = new AddLesson_ForTeacher(((Tuple<int, int>)Add.Tag).Item1, ((Tuple<int, int>)Add.Tag).Item2, TeacherID);
                    AddLesson.Closed += (object __sender, EventArgs __e) => { LoadTimeTable_ByTeacher(TeacherID); };
                    AddLesson.Show();
                };
                ControlList.Add(Add);
            }
            #endregion
            return ControlList;
        }
        public List<Label> GetTimeTableByGroup(int GroupID)
        {
            Size LabelSize = new Size(100, 40);
            List<Label> ControlList = new List<Label>();
            foreach (DataRow Lesson in DAL.UserMethods.GetLessonsByGroup(GroupID))
            {
                Label l = new Label()
                {
                    Name = "label_" + Lesson["Day"] + "_" + Lesson["period"],
                    Text = Lesson["SubjectName"] + "\nWith:" + Lesson["TeacherName"],
                    BackColor = Color.DimGray,
                    BorderStyle = BorderStyle.FixedSingle,
                    ForeColor = SystemColors.ControlText,
                    Size = LabelSize,
                    TabIndex = 0,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = new Tuple<int, int>((int)Lesson["Day"], (int)Lesson["Period"])
                };
                l.Location = new Point(l.Size.Width * ((int)Lesson["Day"] - 1), l.Size.Height * (int)Lesson["period"]);
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
                #region Create ContextMenu
                l.ContextMenu = new ContextMenu();
                l.ContextMenu.Name = (string)Lesson["SubjectName"] + " For " + (string)Lesson["GroupName"];
                MenuItem ViewTeacher = new MenuItem()
                {
                    Name = "menuItem_Teacher",
                    Text = string.Format("View Table For Teacher: {0}", Lesson["TeacherName"]),
                    Tag = Lesson["TeacherID"].ToString(),
                    Break = true
                };
                ViewTeacher.Click += (object _sender, EventArgs _e) => { LoadTimeTable_ByTeacher(int.Parse((string)ViewTeacher.Tag)); };
                MenuItem Edit = new MenuItem()
                {
                    Name = "menuItem_Edit",
                    Text = string.Format("Edit"),
                    Tag = Lesson,
                };
                Edit.Click += (object _sender, EventArgs _e) =>
                {
                    EditLesson_ForGroup form = new EditLesson_ForGroup((DataRow)((MenuItem)_sender).Tag);
                    form.FormClosed += (object __sender, FormClosedEventArgs __e) => { LoadTimeTable_ByGroup(GroupID); };
                    form.Show();

                };
                MenuItem Remove = new MenuItem()
                {
                    Name = "menuItem_Remove",
                    Text = string.Format("Remove"),
                    Tag = Lesson["LessonID"].ToString(),
                };
                Remove.Click += (object sender, EventArgs e) =>
                {
                    int ID = (int.Parse(((MenuItem)sender).Tag.ToString()));
                    DialogResult MsgBoxResult = MessageBox.Show(String.Format("Are You Sure You Would Like To\nRemove Lesson With ID: {0}?", ID), "Confirm", MessageBoxButtons.YesNo);
                    if ((int)MsgBoxResult == 6)
                        DAL.UserMethods.RemoveLesson(ID);
                };
                Remove.Click += (object __sender, EventArgs __e) => { LoadTimeTable_ByGroup(GroupID); };
                l.ContextMenu.MenuItems.AddRange(new MenuItem[] { ViewTeacher, Edit, Remove });
                #endregion
                #region Handle Gaps and Double Lessons
                Label LastControl = new Label() { Tag = new Tuple<int, int>((int)Lesson["Day"], 0) };
                try { LastControl = ControlList.Last(c => ((Tuple<int, int>)c.Tag).Item1 == (int)Lesson["Day"]); }
                catch { }
                Tuple<int, int> Last = (Tuple<int, int>)LastControl.Tag;
                if (Last.Item2 == (int)Lesson["Period"])
                {
                    ControlList.Remove(LastControl);
                    MenuItem Current = new MenuItem((string)Lesson["SubjectName"] + " For " + (string)Lesson["GroupName"]);
                    Current.MenuItems.AddRange(new MenuItem[] { ViewTeacher, Edit, Remove });
                    MenuItem Lst = new MenuItem(LastControl.ContextMenu.Name);
                    if (LastControl.ContextMenu.MenuItems[0].IsParent)
                    {
                        l.ContextMenu = new ContextMenu(new MenuItem[] { Current });
                        l.ContextMenu.MergeMenu(LastControl.ContextMenu);
                    }
                    else
                    {
                        MenuItem[] menu = new MenuItem[3];
                        LastControl.ContextMenu.MenuItems.CopyTo(menu, 0);
                        Lst.MenuItems.AddRange(menu);
                        l.ContextMenu = new ContextMenu(new MenuItem[] { Current, Lst });
                    }
                    l.Text = "Various\nLessons";
                }
                else
                {
                    #region Add FreePeriods
                    for (int period = Last.Item2 + 1; (period < (int)Lesson["Period"]); period++)
                    {
                        /**/
                        Label w = new Label()
                        {
                            Name = "label_" + Lesson["Day"] + "_" + period,
                            Text = "Free Period",
                            BackColor = Color.White,
                            BorderStyle = BorderStyle.FixedSingle,
                            ForeColor = SystemColors.ControlText,
                            Size = LabelSize,
                            TabIndex = 0,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Tag = new Tuple<int, int>((int)Lesson["Day"], period)
                        };
                        w.Location = new Point(w.Size.Width * ((int)Lesson["Day"] - 1), w.Size.Height * period);
                        w.MouseEnter += (object _sender, EventArgs _e) =>
                        {
                            ((Control)_sender).BackColor = Color.FromArgb(((Control)_sender).BackColor.A / 2, ((Control)_sender).BackColor);
                            ((Label)(Control)_sender).Text = "+";
                        };
                        w.MouseLeave += (object _sender, EventArgs _e) =>
                        {
                            try
                            {
                                ((Control)_sender).BackColor = Color.FromArgb(((Control)_sender).BackColor.A * 2, ((Control)_sender).BackColor);
                            }
                            catch { }
                            ((Label)(Control)_sender).Text = "Free Period";
                        };
                        w.Click += (object _sender, EventArgs _e) =>
                        {
                            AddLesson_ForGroup AddLesson = new AddLesson_ForGroup(((Tuple<int, int>)w.Tag).Item1, ((Tuple<int, int>)w.Tag).Item2, GroupID);
                            AddLesson.Closed += (object __sender, EventArgs __e) => { LoadTimeTable_ByGroup(GroupID); };
                            AddLesson.Show();
                        };
                        ControlList.Add(w);
                    }
                    #endregion
                }
                #endregion
                ControlList.Add(l);
            }
            #region Create AddLesson in every day's last slot
            for (int day = 0; day < 7; day++)
            {
                Tuple<int, int> Last = new Tuple<int, int>(day, 0);
                try { Last = (Tuple<int, int>)ControlList.Last(c => ((Tuple<int, int>)c.Tag).Item1 == day).Tag; }
                catch { }
                Label Add = new Label()
                {
                    Name = "label_" + Last.Item1 + "_" + Last.Item2 + 1,
                    Text = " ",
                    BackColor = Color.Transparent,
                    BorderStyle = BorderStyle.FixedSingle,
                    ForeColor = SystemColors.ControlText,
                    Size = LabelSize,
                    TabIndex = 0,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = new Tuple<int, int>(Last.Item1, Last.Item2 + 1)
                };
                Add.Location = new Point(Add.Size.Width * (Last.Item1 - 1), Add.Size.Height * (Last.Item2 + 1));
                Add.MouseEnter += (object _sender, EventArgs _e) =>
                {
                    ((Control)_sender).BackColor = Color.FromArgb(((Control)_sender).BackColor.A / 2, ((Control)_sender).BackColor);
                    ((Label)(Control)_sender).Text = "+";
                };
                Add.MouseLeave += (object _sender, EventArgs _e) =>
                {
                    try
                    {
                        ((Control)_sender).BackColor = Color.FromArgb(((Control)_sender).BackColor.A * 2, ((Control)_sender).BackColor);
                    }
                    catch { }
                    ((Label)(Control)_sender).Text = " ";
                };
                Add.Click += (object _sender, EventArgs _e) =>
                {
                    AddLesson_ForGroup AddLesson = new AddLesson_ForGroup(((Tuple<int, int>)Add.Tag).Item1, ((Tuple<int, int>)Add.Tag).Item2, GroupID);
                    AddLesson.Closed += (object __sender, EventArgs __e) => { LoadTimeTable_ByGroup(GroupID); };
                    AddLesson.Show();
                };
                ControlList.Add(Add);
            }
            #endregion
            return ControlList;
        }
        #endregion
        #endregion
    }
}