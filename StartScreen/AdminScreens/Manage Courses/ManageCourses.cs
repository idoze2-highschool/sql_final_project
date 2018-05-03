using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GystClient.AdminScreens.Manage_Courses
{
    public partial class ManageCourses : Form
    {
        private Dictionary<int, int> GroupIndexToID;
        private string CourseName;
        public ManageCourses()
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
                            ViewCourse(_ID);
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
        public ManageCourses(int CourseID) : this()
        {
            ViewCourse(CourseID);
        }
        private void LoadTree()
        {
            treeView_Search.Nodes.Add(GetTree_Courses());

        }
        private TreeNode GetTree_Courses()
        {
            int CourseCount = 0;
            TreeNode Root = new TreeNode() { Name = "Courses" };
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
                            CourseCount++;
                        }
                    }
                    else
                    {
                        CourseNode.Nodes.Add(GroupNode);
                        CourseCount++;
                        GradeNode.Nodes.Add(CourseNode);
                    }
                }
                else
                {
                    CourseNode.Nodes.Add(GroupNode);
                    CourseCount++;
                    GradeNode.Nodes.Add(CourseNode);
                    Root.Nodes.Add(GradeNode);
                }
            }
            Root.Text = string.Format("Groups [{0}]", CourseCount);
            return Root;
        }
        private void ViewCourse(int CourseID)
        {
            panel_CourseView.Show();
            label_Course_Name.Text = DAL.UserMethods.GetCourseName(CourseID);
            #region Initialize pictureBox_Course_Name_Edit
            pictureBox_Course_Name_Edit.Tag = (bool)false;
            pictureBox_Course_Name_Edit.Location = new Point(label_Course_Name.Bounds.Right, label_Course_Name.Bounds.Top);
            pictureBox_Course_Name_Edit.MouseEnter += (object sender, EventArgs e) =>
            {
                pictureBox_Course_Name_Edit.BorderStyle = BorderStyle.FixedSingle;
            };
            pictureBox_Course_Name_Edit.MouseLeave += (object sender, EventArgs e) =>
            {
                pictureBox_Course_Name_Edit.BorderStyle = BorderStyle.None;
            };
            pictureBox_Course_Name_Edit.Click += (object sender, EventArgs e) =>
            {
                if ((bool)pictureBox_Course_Name_Edit.Tag)
                {
                    pictureBox_Course_Name_Edit.Tag = false;
                    pictureBox_Course_Name_Edit.Tag = true;
                    ViewCourse(CourseID);
                    pictureBox_Course_Name_Edit.Parent.Controls.RemoveByKey("textBox_Group_Name");
                    label_Course_Name.Text = DAL.UserMethods.GetGroupName(CourseID);
                    this.pictureBox_Grade_Edit.Image = global::GystClient.Properties.Resources.EditPencil;
                }
                else
                {
                    pictureBox_Course_Name_Edit.Tag = true;
                    TextBox EditGroupName = new TextBox()
                    {
                        Name = "textBox_Group_Name",
                        Location = label_Course_Name.Location,
                        Size = label_Course_Name.Size,
                        Text = label_Course_Name.Text
                    };
                    EditGroupName.TextChanged += (object _sender, EventArgs _e) =>
                    {
                        CourseName = EditGroupName.Text;
                    };
                    label_Course_Name.Parent.Controls.Add(EditGroupName);
                    EditGroupName.BringToFront();
                    pictureBox_Course_Name_Edit.Image = global::GystClient.Properties.Resources.Confirm;
                }
            };
            #endregion
            label_Grade_Value.Text = Methods.ToIndexingNumber(DAL.UserMethods.GetCourseGrade(CourseID))+" Grade";
            #region Initialize pictureBox_Grade_Edit
            pictureBox_Grade_Edit.Location = new Point(label_Course_Name.Bounds.Right, label_Course_Name.Bounds.Top);
            pictureBox_Grade_Edit.MouseEnter += (object sender, EventArgs e) =>
            {
                pictureBox_Grade_Edit.BorderStyle = BorderStyle.FixedSingle;
            };
            pictureBox_Grade_Edit.MouseLeave += (object sender, EventArgs e) =>
            {
                pictureBox_Grade_Edit.BorderStyle = BorderStyle.None;
            };
            pictureBox_Grade_Edit.Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("Not Implemeted!");
            };
            #endregion
            LoadGroups(CourseID);
        }
        private void LoadGroups(int CourseID)
        {
            listBox_Course_Subjects.Items.Clear();
            GroupIndexToID = new Dictionary<int, int>();
            foreach (DataRow Student in DAL.UserMethods.GetStudentsOfGroup(CourseID))
            {
                listBox_Course_Subjects.Items.Add(((string)Student["FName"]) + " " + ((string)Student["LName"])[0] + ".");
                GroupIndexToID.Add(listBox_Course_Subjects.Items.Count - 1, (int)Student["UserID"]);
            }
        }
    }
}
