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
        public ManageTimetable()
        {
            InitializeComponent();
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
                l.Location = new Point( l.Size.Width * (day - 1), 0);
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
                    l.Location = new Point( l.Size.Width * (day - 1), l.Size.Height * period);
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

        private void L_Click(object sender, EventArgs e)
        {

            EditPeriod form = new EditPeriod(((Tuple<int, int>)((Control)sender).Tag).Item1, ((Tuple<int, int>)((Control)sender).Tag).Item2);
            form.FormClosed += (object _sender, FormClosedEventArgs _e) => { Show(); };
            Hide();
        }

        private void treeView_Search_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }

}

