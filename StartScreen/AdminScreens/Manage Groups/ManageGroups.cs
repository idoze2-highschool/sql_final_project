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
        private string GroupName;
        private int CourseID;
        private Dictionary<int, int> StudentIndexToID;
        public ManageGroups()
        {
            FormClosed += (object sender, FormClosedEventArgs e) => { try { Owner.Show(); } catch { } };
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
                catch
                {
                    //throw;
                }
            };
            LoadTree();
        }
        public ManageGroups(int GroupID) : this()
        {
            ViewGroup(GroupID);
        }
        private void LoadTree()
        {
            treeView_Search.Nodes.Clear();
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
                TreeNode GradeNode = new TreeNode(Methods.ToIndexingNumber(int.Parse(Grade)) + " Grade") { Name = string.Format("Grade:{0}", Grade) };
                TreeNode CourseNode = new TreeNode(CourseName + " Course") { Name = string.Format("Course:{0}", Group["CourseID"]) };
                TreeNode GroupNode = new TreeNode(GroupName) { Name = string.Format("Group:{0}", Group["GroupID"]) };
                if (Root.Nodes.ContainsKey(GradeNode.Name))
                {
                    GradeNode = Root.Nodes.Find(GradeNode.Name, false)[0];
                    if (GradeNode.Nodes.ContainsKey(CourseNode.Name))
                    {
                        CourseNode = GradeNode.Nodes.Find(CourseNode.Name, false)[0];
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
            panel_GroupView.Show();
            LoadTree();
            treeView_Search.Nodes.Find(string.Format("Group:{0}", GroupID), true)[0].EnsureVisible();
            #region Initialize label_Group_Name
            label_Group_Name.Text = DAL.UserMethods.GetGroupName(GroupID);
            #endregion 
            #region Initialize pictureBox_Group_Name_Edit
            pictureBox_Group_Name_Edit.Tag = (bool)false;
            pictureBox_Group_Name_Edit.Location = new Point(label_Group_Name.Bounds.Right, label_Group_Name.Bounds.Top);
            pictureBox_Group_Name_Edit.MouseEnter += (object sender, EventArgs e) =>
             {
                 pictureBox_Group_Name_Edit.BorderStyle = BorderStyle.FixedSingle;
             };
            pictureBox_Group_Name_Edit.MouseLeave += (object sender, EventArgs e) =>
             {
                 pictureBox_Group_Name_Edit.BorderStyle = BorderStyle.None;

             };
            pictureBox_Group_Name_Edit.Click += (object sender, EventArgs e) =>
            {
                if ((bool)pictureBox_Group_Name_Edit.Tag)
                {
                    DAL.UserMethods.UpdateGroup(GroupID, GroupName);
                    pictureBox_Group_Name_Edit.Tag = false;
                    label_Group_Name.Parent.Controls.RemoveByKey("textBox_Group_Name");
                    label_Group_Name.Text = DAL.UserMethods.GetGroupName(GroupID);
                    this.pictureBox_Group_Name_Edit.Image = global::GystClient.Properties.Resources.EditPencil;
                    ViewGroup(GroupID);
                }
                else
                {
                    pictureBox_Group_Name_Edit.Tag = true;
                    TextBox EditGroupName = new TextBox()
                    {
                        Name = "textBox_Group_Name",
                        Location = label_Group_Name.Location,
                        Size = label_Group_Name.Size,
                        Text = label_Group_Name.Text
                    };
                    EditGroupName.TextChanged += (object _sender, EventArgs _e) =>
                     {
                         GroupName = EditGroupName.Text;
                     };
                    label_Group_Name.Parent.Controls.Add(EditGroupName);
                    EditGroupName.BringToFront();
                    pictureBox_Group_Name_Edit.Image = global::GystClient.Properties.Resources.Confirm;
                }
            };
            #endregion
            #region Initialize label_Course_Name
            label_Course_Name.Text = (string)DAL.UserMethods.GetCourseOfGroup(GroupID)["CourseName"];
            label_Course_Name.Links.Clear();
            label_Course_Name.Links.Add(0, label_Course_Name.Text.Length, (int)DAL.UserMethods.GetCourseOfGroup(GroupID)["CourseID"]);
            label_Course_Name.LinkClicked += (object sender, LinkLabelLinkClickedEventArgs e) =>
             {
                 Manage_Courses.ManageCourses Form = new Manage_Courses.ManageCourses((int)((LinkLabel)sender).Links[0].LinkData);
                 Owner.AddOwnedForm(Form);
                 Owner.RemoveOwnedForm(this);
                 Close();
                 Form.Show();
             };
            #endregion
            #region Initialize pictureBox_Course_Edit
            pictureBox_Course_Edit.Tag = (bool)false;
            pictureBox_Course_Edit.Location = new Point(label_Course_Name.Bounds.Right, label_Course_Name.Bounds.Top);
            pictureBox_Course_Edit.MouseEnter += (object sender, EventArgs e) =>
            {
                pictureBox_Course_Edit.BorderStyle = BorderStyle.FixedSingle;
            };
            pictureBox_Course_Edit.MouseLeave += (object sender, EventArgs e) =>
            {
                pictureBox_Course_Edit.BorderStyle = BorderStyle.None;
            };
            pictureBox_Course_Edit.Click += (object sender, EventArgs e) =>
            {
                if ((bool)pictureBox_Course_Edit.Tag)
                {
                    pictureBox_Course_Edit.Tag = false;

                }
                else
                {
                    pictureBox_Course_Edit.Tag = true;
                }
            };
            #endregion
            LoadStudents(GroupID);
        }
        private void LoadStudents(int GroupID)
        {
            listBox_Group_Members.Items.Clear();
            StudentIndexToID = new Dictionary<int, int>();
            foreach (DataRow Student in DAL.UserMethods.GetStudentsOfGroup(GroupID))
            {
                listBox_Group_Members.Items.Add(((string)Student["FName"]) + " " + ((string)Student["LName"])[0] + ".");
                StudentIndexToID.Add(listBox_Group_Members.Items.Count - 1, (int)Student["UserID"]);
            }
        }
    }
}
