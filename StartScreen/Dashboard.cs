using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GystClient
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            label_Welcome.Text = "Welcome Back, " + Program.user.Name+".";
            timer_Clock.Start();
        }

        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            string txt = "";
            txt += DateTime.Today.ToShortDateString();
            txt += " ";
            txt += DateTime.Now.ToLongTimeString();
            label_Clock.Text = txt;
        }

        private void button_CurrentLesson_Click(object sender, EventArgs e)
        {
            CurrentClass cc = new CurrentClass();
            cc.FormClosed += Cc_FormClosed;
            cc.Show();
            Hide();
        }

        private void Cc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}
