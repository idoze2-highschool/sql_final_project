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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            label_Welcome.Text = "Welcome Back, " + Program.user.FName + ".";
            timer_Clock.Start();
            timer_Clock.Tick += (object _sender, EventArgs _e) =>
            {
                string txt = "";
                txt += DateTime.Today.ToShortDateString();
                txt += " ";
                txt += DateTime.Now.ToLongTimeString();
                label_Clock.Text = txt;
            };
        }
        private void button_Manage_Timetable_Click(object sender, EventArgs e)
        {
            Manage_Timetable.ManageTimetable form = new Manage_Timetable.ManageTimetable();
            form.FormClosed += (object s, FormClosedEventArgs ev) => { Show(); };
            form.Show();
            Hide();
        }
        private void button_Manage_Groups_Click(object sender, EventArgs e)
        {
            Manage_Groups.ManageGroups form = new Manage_Groups.ManageGroups();
            form.FormClosed += (object s, FormClosedEventArgs ev) => { Show(); };
            form.Show();
            Hide();
        }
    }
}
