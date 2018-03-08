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
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

            for (int i = 0; i < days.Length; i++)
            {
                Label l = new Label
                {
                    BackColor = Color.FromArgb(255, 224, 192),
                    BorderStyle = BorderStyle.FixedSingle,
                    ForeColor = SystemColors.ControlText,
                    Size = new Size(54, 29),
                    TabIndex = 0,
                    Text = days[i].Substring(0,3),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                l.Location = new Point(45 + l.Size.Width * i, 25);
                Controls.Add(l);
                for (int k = 1; k < 11; k++)
                {
                    l = new Label
                    {
                        BackColor = Color.FromArgb(255, 224, 192),
                        BorderStyle = BorderStyle.FixedSingle,
                        ForeColor = SystemColors.ControlText,
                        Size = new Size(54, 29),
                        TabIndex = 0,
                        Text = days[i],
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    l.Text = "Period " + (k).ToString();
                    l.Location = new Point(45 + l.Size.Width * i, 25 + l.Size.Height * k);
                    l.Click += (object _sender, EventArgs _e) =>
                      {
                          EditPeriod form = new EditPeriod(i,k);
                          form.FormClosed += (object s, FormClosedEventArgs ev) => { Show(); };
                          form.Show();
                          Hide();
                      };
                    l.MouseEnter += (object _sender, EventArgs _e) =>
                    { l.BackColor = Color.Orange; };
                    l.MouseLeave += (object _sender, EventArgs _e) =>
                    { l.BackColor = Color.FromArgb(255, 224, 192); };
                    Controls.Add(l);
                }
            }
        }

    }
}
