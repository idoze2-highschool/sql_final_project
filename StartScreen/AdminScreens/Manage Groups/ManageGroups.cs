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

namespace GystClient.AdminScreens.Manage_Groups
{
    public partial class ManageGroups : Form
    {
        public ManageGroups()
        {
            InitializeComponent();
            treeView_Search.NodeMouseDoubleClick += (object sender, TreeNodeMouseClickEventArgs e) =>
            {
                TreeNode Selection = ((TreeView)sender).SelectedNode;
                string _Name = Selection.Name.ToString();
                try
                {
                    int _ID = int.Parse(_Name.Substring(_Name.IndexOf(":") + 1));
                    switch (_Name.Substring(0, _Name.IndexOf(':')))
                    {
                        default:
                            break;
                        case "Group":
                            ViewGroup(_ID);
                            break;
                    }
                }
                catch{
                    //throw;
                }
            };
            LoadTree();
        }
        private void LoadTree()
        {
            treeView_Search.Nodes.Add(GetTree_Groups());
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
        private void ViewGroup(int GroupID)
        {
            label_Group_Name.Text = DAL.UserMethods.GetGroupName(GroupID);
            label_Course_Name.Text = (string)DAL.UserMethods.GetCourse(GroupID)["CourseName"];
            label_Course_Name.LinkClicked += (object sender, LinkLabelLinkClickedEventArgs e) =>
             {
                 Manage_CoursesManageCourses((int)((LinkLabel.Link)sender).LinkData);
             };
        }
    }
}
