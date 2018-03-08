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
        }

        private void button_Manage_Timetable_Click(object sender, EventArgs e)
        {
            ManageTimetable form = new ManageTimetable();
            form.FormClosed += (object s, FormClosedEventArgs ev) => { Show(); };
            form.Show();
            Hide();
        }
    }
}
