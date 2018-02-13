using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Component = DAL.Component;
using DAL;
using WCF;

namespace GystClient
{
    public partial class LoginScreen : Form
    {

        public LoginScreen()
        {
            InitializeComponent();

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            //TODO: LOGIN
            if (Login(textBox_Username.Text, textBox_Password.Text))
            {
                Dashboard dashboard = new Dashboard();
                (dashboard).Show();
                dashboard.FormClosed += Dashboard_FormClosed;
                Hide();
            }
            else
            {
                label_InvalidLogin.Visible = true;
            }
        }

        private bool Login(string Username, string Password)
        {
            //TODO
            if( DAL.UserMethods.UserExists(Username, Password))
            {
                Program.user = DAL.UserMethods.GetUser(Username, Password);
                return true;
            }
            return false;
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Password.Text != "Password"
                && textBox_Password.Text != ""
                && textBox_Username.Text != "Username"
                && textBox_Username.Text != "")
                button_Login.Enabled = true;
            else
                button_Login.Enabled = false;
        }
        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Password.Text != "Password"
                && textBox_Password.Text != ""
                && textBox_Username.Text != "Username"
                && textBox_Username.Text != "")
                button_Login.Enabled = true;
            else
                button_Login.Enabled = false;
        }

    }
}
