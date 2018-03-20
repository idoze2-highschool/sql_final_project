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
            TreeNode Root = new TreeNode() { Name = "Groups" };
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
            panel_table.Controls.AddRange(Timetable.GetBase().ToArray());
        }
        public void LoadTimeTable_ByTeacher(int TeacherID)
        {
            panel_table.Controls.Clear();
            panel_table.Controls.AddRange(Timetable.ByTeacherID(TeacherID).ToArray());
            treeView_Search.CollapseAll();
            TreeNode Selection = treeView_Search.Nodes.Find(String.Format("Teacher:{0}", TeacherID), true)[0];
            treeView_Search.SelectedNode = Selection;
        }
        public void LoadTimeTable_ByGroup(int GroupID)
        {
            panel_table.Controls.Clear();
            panel_table.Controls.AddRange(Timetable.ByGroupID(GroupID).ToArray());
            treeView_Search.CollapseAll();
            TreeNode Selection = treeView_Search.Nodes.Find(String.Format("Group:{0}", GroupID), true)[0];
            treeView_Search.SelectedNode = Selection;
        }
        #endregion
    }
}