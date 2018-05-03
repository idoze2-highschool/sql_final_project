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
    public partial class Student : MetroFramework.Controls.MetroUserControl
    {
        private DAL.Component.User User;
        public int UserID { get => User.ID; set => SetUser(DAL.Methods.GetUserByID(value)); }
        public Student()
        {
            InitializeComponent();
            
        }
        private void SetUser(DAL.Component.User User)
        {
            this.User = User;
            label_Name.Text = User.FName + " " + User.LName;
            button_View_Groups.Click += (object sender, EventArgs e) =>
             {
                 Groups.ViewGroups s = new Groups.ViewGroups();
                 s.
                 ((AdminDashboard)FindForm()).ViewScreen();
             };
        }
    }
}
