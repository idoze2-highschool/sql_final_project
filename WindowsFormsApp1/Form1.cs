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
using DAL = DALOrg;

namespace Client
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
            Focus();
        }
        private void button_Login_Click(object sender, EventArgs e)
        {
            if (Login(textBox_Username.Text, textBox_Password.Text))
            {
                if (checkBox_Remember.Checked)
                {
                    Properties.Settings.Default.SavedUsername = textBox_Username.Text;
                    Properties.Settings.Default.SavedPassword = textBox_Password.Text;
                    Properties.Settings.Default.Remember = true;
                    Properties.Settings.Default.Save();
                }
                ShowDashboard();
            }
            else
            {
                label_InvalidLogin.Visible = true;
            }
        }
        private void ShowDashboard()
        {
            Close();
            Application.Restart();
        }
        private bool Login(string Username, string Password)
        {
            //TODO
            if (DAL.UserMethods.UserExists(Username, Password))
            {
                Program.user = DAL.UserMethods.GetUser(Username, Password);
                return true;
            }
            return false;
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
        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
