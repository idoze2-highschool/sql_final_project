using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using DAL = DALOrg;

namespace GystClient.AdminScreens
{
    static class Timetable
    {
        #region TimeTable Base
        public static List<Control> GetBase(Size LabelSize, Color DefaultBackColor)
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
        public static List<Control> GetBase()
        {
            return GetBase(new Size(80, 30), Color.White);
        }
        #endregion
        #region TimeTable By Filter
        public static List<Control> ByTeacherID(int TeacherID)
        {
            List<Control> TableControls = GetBase(new Size(100, 40), Color.White);
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
                    Tag = TeacherToLesson["LessonID"].ToString(),
                };
                Edit.Click += menuItem_Edit_Click;
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
        public static List<Control> ByGroupID(int GroupID)
        {
            List<Control> TableControls = GetBase(new Size(70, 30), Color.White);
            foreach (DataRow GroupToLessons in DAL.UserMethods.GetLessonsByGroup(GroupID))
            {
                int index = TableControls.FindIndex(c => c.Name == "label_" + GroupToLessons["Day"] + "_" + GroupToLessons["Period"]);
                TableControls[index].Text = GroupToLessons["SubjectName"] + "\nWith:" + GroupToLessons["TeacherName"];
                TableControls[index].BackColor = Color.Gray;
                #region Create ContextMenu
                ContextMenu menu = new ContextMenu();
                MenuItem ViewTeacher = new MenuItem()
                {
                    Name = "menuItem_Teacher",
                    Text = string.Format("View Table For Teacher: {0}", GroupToLessons["TeacherName"]),
                    Tag = GroupToLessons["TeacherID"].ToString(),
                    BarBreak = true
                };
                ViewTeacher.Click += (object _sender, EventArgs _e) => { LoadTimeTable_ByTeacher(int.Parse((string)ViewTeacher.Tag)); };
                MenuItem Edit = new MenuItem()
                {
                    Name = "menuItem_Edit",
                    Text = string.Format("Edit"),
                    Tag = GroupToLessons["LessonID"].ToString(),
                };
                Edit.Click += menuItem_Edit_Click;
                MenuItem Remove = new MenuItem()
                {
                    Name = "menuItem_Remove",
                    Text = string.Format("Remove"),
                    Tag = GroupToLessons["LessonID"].ToString(),
                };
                Remove.Click += menuItem_Remove_Click;
                menu.MenuItems.AddRange(new MenuItem[] { ViewTeacher, Edit, Remove });
                TableControls[index].ContextMenu = menu;
                #endregion
            }
            return TableControls;
        }
        #endregion
        private static void menuItem_Remove_Click(object sender, EventArgs e)
        {
            int ID = (int.Parse(((MenuItem)sender).Tag.ToString()));
            DialogResult MsgBoxResult = MessageBox.Show(String.Format("Are You Sure You Would Like To\nRemove Lesson With ID: {0}?", ID), "Confirm", MessageBoxButtons.YesNo);
            if ((int)MsgBoxResult == 6)
                DAL.UserMethods.RemoveLesson(ID);
        }
        private static void menuItem_Edit_Click(object sender, EventArgs e)
        {
            int ID = (int.Parse(((MenuItem)sender).Tag.ToString()));
            DataRow Lesson = DAL.UserMethods.GetLesson(ID);
            EditLesson editLesson = new EditLesson((int)Lesson["Day"], (int)Lesson["Period"]);
        }
    }
}
