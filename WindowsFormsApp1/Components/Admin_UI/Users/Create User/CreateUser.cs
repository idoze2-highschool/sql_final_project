using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Components.Base;
using Client.Components.Admin_UI.Users.Profiles;

namespace Client.Components.Admin_UI.Users
{
    public partial class CreateUser : MetroFramework.Controls.MetroUserControl
    {
        private int CreatedUserID = -1;
        public CreateUser()
        {
            InitializeComponent();
            button_Cancel.Click += (object sender, EventArgs e) =>
            {
                Dispose();
            };
            textBox_FName.TextChanged += ValidateInput;
            textBox_LName.TextChanged += ValidateInput;
            textBox_ID.TextChanged += ValidateInput;
        }
        private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_Type.SelectedIndex)
            {
                case 1:
                    groupBox_Student.Hide();
                    groupBox_Teacher.Show();
                    break;
                case 2:
                    groupBox_Teacher.Hide();
                    groupBox_Student.Show();
                    break;
                default:
                    groupBox_Student.Hide();
                    groupBox_Teacher.Hide();
                    break;
            }
            ValidateInput(sender, e);
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            string FName = textBox_FName.Text;
            string LName = textBox_LName.Text;
            int UserType = comboBox_Type.SelectedIndex - 1;
            string Username = textBox_ID.Text;
            string Password = textBox_ID.Text;
            CreateNewUser(Username, Password, FName, LName, UserType);
        }
        private void CreateNewUser(string Username, string Password, string LName, string Surname, int UserType)
        {
            int ID = DAL.Methods.CreateUser(Username, Password, LName, Surname, UserType);
            switch (UserType)
            {
                case 1:

                    break;

            }
        }
        private void ValidateInput(object sender, EventArgs e)
        {
            bool BaseTeacher = true;
            bool BaseStudent = true;
            /*
             TODO:
             Validate Teacher Selection
             Validate Student Selection
             */
            bool FNameV = FNameValid(), LNameV = LNameValid(), IDV = IDValid();
            button_Save.Enabled = (
               FNameV &&
                LNameV &&
                IDV &&
                comboBox_Type.SelectedIndex != -1 &&
                BaseTeacher &&
                BaseStudent
                );
        }
        #region Validations
        private bool FNameValid()
        {
            if (Methods.IsValidString(textBox_FName.Text))
            {
                label_FName_Title.ForeColor = ForeColor;
                return true;
            }
            else
            {
                if (textBox_FName.Text != "")
                    label_FName_Title.ForeColor = Color.Red;
                else
                    label_FName_Title.ForeColor = ForeColor;
                return false;
            }
        }
        private bool LNameValid()
        {
            if (Methods.IsValidString(textBox_LName.Text))
            {
                label_LName_Title.ForeColor = ForeColor;
                return true;
            }
            else
            {
                if (textBox_LName.Text != "")
                    label_LName_Title.ForeColor = Color.Red;
                else
                    label_LName_Title.ForeColor = ForeColor;
                return false;
            }
        }
        private bool IDValid()
        {
            if (Methods.IsValidSocialID(textBox_ID.Text))
            {
                label_ID_Title.ForeColor = ForeColor;
                return true;
            }
            else
            {
                if (textBox_ID.Text != "")
                    label_ID_Title.ForeColor = Color.Red;
                else
                    label_ID_Title.ForeColor = ForeColor;
                return false;
            }
        }
        #endregion
    }
}
