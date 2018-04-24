using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Client
{
    public partial class Dashboard : MetroForm
    {
        public Dashboard()
        {
           
            InitializeComponent();
            //this.BackImage = global::Client.Properties.Resources.Royalblue;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Remember = false;
            Properties.Settings.Default.Save();
            Close();
            Application.Restart();
        }
    }
}
