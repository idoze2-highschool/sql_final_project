using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace Client.Components.Admin_UI.Users.Profiles
{
    public partial class Admin : MetroFramework.Controls.MetroUserControl
    {
        private DAL.Component.User User;
        public int UserID { get => User.ID; set => User = DAL.Methods.GetUserByID(value); }
        public Admin()
        {
            InitializeComponent();
            label_Name.Text = User.FName + " " + User.LName;
        }
    }
}
