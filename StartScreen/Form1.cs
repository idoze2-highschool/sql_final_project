using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartScreen
{
    public partial class Form1 : Form
    {
        public static int UserID;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            //TODO: LOGIN
            if (Login(textBox_Username.Text,textBox_Password.Text))
            {
                Dashboard dashboard = new Dashboard();
                (dashboard).Show();
                dashboard.FormClosed += Dashboard_FormClosed;
                Hide();
            }
            else
            {

            }
        }

        private bool Login(string Username, string Password)
        {
            throw new NotImplementedException();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
