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
        private Dictionary<int, Form> UsertypeToForm;
        public LoginScreen()
        {
            InitializeComponent();
            UsertypeToForm = new Dictionary<int, Form>();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (Login(textBox_Username.Text, textBox_Password.Text))
            {
                UsertypeToForm.Add(-1, new AdminScreens.Dashboard());//Usertype -1 => Admin
                UsertypeToForm.Add(0, new TeacherScreens.Dashboard());//Usertype 0 => Teacher
                UsertypeToForm.Add(1, new StudentScreens.Dashboard());//Usertype 1 => Student
                var form = UsertypeToForm[Program.user.UserType];
                (form).Show();
                form.FormClosed += (object _sender, FormClosedEventArgs _e) => { Close(); };
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
        private void checkBox_RememberMe_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
