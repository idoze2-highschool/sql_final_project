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
            ManageTimetable form = new ManageTimetable();
            form.FormClosed += (object s, FormClosedEventArgs ev) => { Show(); };
            form.Show();
            Hide();
        }

        private void timer_Clock_Tick(object sender, EventArgs e)
        {

        }
    }
}
