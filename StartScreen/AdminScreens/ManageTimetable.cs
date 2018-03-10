using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GystClient.AdminScreens
{
    public partial class ManageTimetable : Form
    {
        Tuple<int, int> Selected = new Tuple<int, int>(1, 1);
        public ManageTimetable()
        {
            InitializeComponent();
            LoadTree();
            LoadTimeTable();
        }
        public void LoadTimeTable()
        {
            for (int day = 1; day < 7; day++)
            {
                string txt = Methods.GetDayName(day).Substring(0, 3);
                Label l = new Label
                {
                    Name = "label_" + txt,
                    BackColor = Color.FromArgb(255, 224, 192),
                    BorderStyle = BorderStyle.FixedSingle,
                    ForeColor = SystemColors.ControlText,
                    Size = new Size(54, 29),
                    TabIndex = 0,
                    Text = txt,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                l.Location = new Point(l.Size.Width * (day - 1), 0);
                panel_table.Controls.Add(l);
                for (int period = 1; period < 11; period++)
                {
                    txt = Methods.ToIndexingNumber(period) + " Period";
                    l = new Label
                    {
                        Name = "label_" + txt,
                        Text = txt,
                        BackColor = Color.FromArgb(255, 224, 192),
                        BorderStyle = BorderStyle.FixedSingle,
                        ForeColor = SystemColors.ControlText,
                        Size = new Size(54, 29),
                        TabIndex = 0,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Tag = new Tuple<int, int>(day, period)

                    };
                    l.Location = new Point(l.Size.Width * (day - 1), l.Size.Height * period);
                    l.Click += L_Click;
                    l.MouseEnter += (object _sender, EventArgs _e) =>
                    {
                        ((Control)_sender).BackColor = Color.Orange;
                        ((Control)_sender).Text = "View Lessons";
                    };
                    l.MouseLeave += (object _sender, EventArgs _e) =>
                    {
                        ((Control)_sender).BackColor = Color.FromArgb(255, 224, 192);
                        ((Control)_sender).Text = Methods.ToIndexingNumber(((Tuple<int, int>)((Control)_sender).Tag).Item2) + " Period";
                    };
                    panel_table.Controls.Add(l);
                };
            }
        }
        public void LoadTree()
        {
            treeView_Search.Nodes.Add(GetTree_Teachers());
            treeView_Search.Nodes.Add(GetTree_HomeRoomClasses());
            treeView_Search.NodeMouseDoubleClick += (object sender, TreeNodeMouseClickEventArgs e) =>
              {

               };
        }
        private TreeNode GetTree_Teachers()
        {
            TreeNode Root = new TreeNode();
            foreach (DataRow Teacher in DAL.UserMethods.GetTeachers())
            {
                TreeNode child = new TreeNode(Teacher["FName"].ToString() + " " + Teacher["LName"].ToString());
                child.Tag = int.Parse(Teacher["UserID"].ToString());
                Root.Nodes.Add(child);
            }
            Root.Text = string.Format("Teachers [{0}]", Root.Nodes.Count);
            Root.Tag = Root.Text;
            return Root;
        }
        private TreeNode GetTree_HomeRoomClasses()
        {
            TreeNode Root = new TreeNode();
            foreach (DataRow Student in DAL.UserMethods.GetStudentsToClasses())
            {
                string Grade = (Student["Grade"]).ToString();
                string Class = (Student["ClassNumber"]).ToString();
                string Course = (Student["Course"]).ToString();
                TreeNode GradeNode = new TreeNode(Methods.ToIndexingNumber(int.Parse(Grade))) { Name = Grade };
                TreeNode ClassNode = new TreeNode(Class) { Name = Class};
                TreeNode CourseNode = new TreeNode(Course) { Name = Course};
                if(Root.Nodes.ContainsKey(Grade))
                {
                    GradeNode = Root.Nodes.Find(Grade,false)[0];
                    if(GradeNode.Nodes.ContainsKey(Class))
                    {
                        ClassNode = GradeNode.Nodes.Find(Class, false)[0];
                        if(ClassNode.Nodes.ContainsKey(Course))
                        {
                            CourseNode = ClassNode.Nodes.Find(Course, false)[0];
                        }
                        else
                        {
                            ClassNode.Nodes.Add(CourseNode);
                        }
                    }
                    else
                    {
                        ClassNode.Nodes.Add(CourseNode);
                        GradeNode.Nodes.Add(ClassNode);
                    }
                }
                else
                { 
                    ClassNode.Nodes.Add(CourseNode);
                    GradeNode.Nodes.Add(ClassNode);
                    Root.Nodes.Add(GradeNode);
                }

            }
            Root.Text = string.Format("Home-Room Classes [{0}]", Root.Nodes.Count);
            Root.Tag = Root.Text;
            return Root;
        }
        private void L_Click(object sender, EventArgs e)
        {
            Selected = (Tuple<int, int>)((Control)sender).Tag;
        }
        public void LoadTimeTableByTeacher()
        {
            for (int day = 1; day < 7; day++)
            {
                string txt = Methods.GetDayName(day).Substring(0, 3);
                Label l = new Label
                {
                    Name = "label_" + txt,
                    BackColor = Color.FromArgb(255, 224, 192),
                    BorderStyle = BorderStyle.FixedSingle,
                    ForeColor = SystemColors.ControlText,
                    Size = new Size(54, 29),
                    TabIndex = 0,
                    Text = txt,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                l.Location = new Point(l.Size.Width * (day - 1), 0);
                panel_table.Controls.Add(l);
                for (int period = 1; period < 11; period++)
                {
                    txt = Methods.ToIndexingNumber(period) + " Period";
                    l = new Label
                    {
                        Name = "label_" + txt,
                        Text = txt,
                        BackColor = Color.FromArgb(255, 224, 192),
                        BorderStyle = BorderStyle.FixedSingle,
                        ForeColor = SystemColors.ControlText,
                        Size = new Size(54, 29),
                        TabIndex = 0,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Tag = new Tuple<int, int>(day, period)

                    };
                    l.Location = new Point(l.Size.Width * (day - 1), l.Size.Height * period);
                    l.Click += L_Click;
                    l.MouseEnter += (object _sender, EventArgs _e) =>
                    {
                        ((Control)_sender).BackColor = Color.Orange;
                        ((Control)_sender).Text = "View Lessons";
                    };
                    l.MouseLeave += (object _sender, EventArgs _e) =>
                    {
                        ((Control)_sender).BackColor = Color.FromArgb(255, 224, 192);
                        ((Control)_sender).Text = Methods.ToIndexingNumber(((Tuple<int, int>)((Control)_sender).Tag).Item2) + " Period";
                    };
                    panel_table.Controls.Add(l);
                };
            }
        }
    }

}

