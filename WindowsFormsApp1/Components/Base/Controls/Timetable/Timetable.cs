using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Component.Data;
using Client.Components.Admin_UI;

namespace Client
{
    public partial class Timetable : MetroFramework.Controls.MetroUserControl
    {
        public Timetable()
        {
            InitializeComponent();
            Table.ContextMenu = new ContextMenu();
            MenuItem AddLesson = new MenuItem("Add Lesson");
            AddLesson.Click += (object sender, EventArgs e) =>
            {
            };
        }
        public void AddLesson(Lesson Lesson,string Format)
        {
            Format = Format.Replace("[SubjectName]", DAL.Methods.GetSubjectName(Lesson.SubjectID));
            Format = Format.Replace("[GroupName]", DAL.Methods.GetGroupName(Lesson.GroupID));
            Label l = new Label()
            {
                Name = "label_" + Lesson.Day + "_" + Lesson.Period,
                Text = Format,
                BackColor = BackColor,
                BorderStyle = BorderStyle.None,
                ForeColor = ForeColor,
                Dock = DockStyle.Fill,
                TabIndex = 0,
                Margin = new Padding(0),
                Padding = new Padding(0),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(Font.FontFamily,Font.Size*0.95F),
                Tag = Lesson
            };
            l.MouseEnter += (object _sender, EventArgs _e) =>
            {
                Color temp = ((Control)_sender).BackColor;
                ((Control)_sender).BackColor = ((Control)_sender).ForeColor;
                ((Control)_sender).ForeColor = temp;
            };
            l.MouseLeave += (object _sender, EventArgs _e) =>
            {
                Color temp = ((Control)_sender).BackColor;
                ((Control)_sender).BackColor = ((Control)_sender).ForeColor;
                ((Control)_sender).ForeColor = temp;
            };
            for (int row = 1; row <= Lesson.Period; row++)
            {
                if (Table.GetControlFromPosition(0, row) == null)
                {
                    MetroFramework.Controls.MetroLabel c = new MetroFramework.Controls.MetroLabel()
                    {
                        Dock = DockStyle.Fill,
                        Text = row.ToString(),
                        UseCustomBackColor = true,
                        UseCustomForeColor = true
                    };
                    Table.Controls.Add(c, 0, row);
                }
            }
            Table.Controls.Add(l, Lesson.Day, Lesson.Period);
        }
        public void AddLessons(Lesson[] Lessons,string format)
        {
            foreach (Lesson Lesson in Lessons)
            {
                AddLesson(Lesson,format);
            }
        }
    }
}
