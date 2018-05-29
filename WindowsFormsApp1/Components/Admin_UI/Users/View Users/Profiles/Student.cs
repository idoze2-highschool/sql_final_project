using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Component.Data;

namespace Client.Components.Admin_UI.Users.Profiles
{
    public partial class Student : MetroFramework.Controls.MetroUserControl
    {
        private User User;
        public Student() : this(0)
        { 
        }
        public Student(int UserID)
        {
            InitializeComponent();
            SetUser(DAL.Methods.GetUserByID(UserID));
        }
        private void SetUser(User User)
        {
            this.User = User;
            label_Name.Text = User.FName + " " + User.LName;
            button_View_Groups.Click += (object sender, EventArgs e) =>
             {
                 Groups.ViewGroups s = new Groups.ViewGroups(User);
                 ((AdminDashboard)FindForm()).ViewScreen(s);
             };
        }
    }
}
