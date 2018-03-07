using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GystClient.TeacherScreens
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            label_Welcome.Text = "Welcome Back, " + Program.user.FName+".";
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
        private void timer_Clock_Tick(object sender, EventArgs e)
        {

        }
        private void button_CurrentLesson_Click(object sender, EventArgs e)
        {
            CurrentClass cc = new CurrentClass();
            cc.FormClosed += (object s, FormClosedEventArgs ev) => {Show();};
            cc.Show();
            Hide();
        }
    }
}
