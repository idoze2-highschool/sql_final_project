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
    public partial class ViewUsers : MetroFramework.Controls.MetroUserControl
    {
        public ViewUsers()
        {
            InitializeComponent();
            FilterSelector.Invalidated += (object sender, InvalidateEventArgs e) => { LoadResults(); };
            ResultGrid.CellDoubleClick += (object sender, DataGridViewCellEventArgs e) =>
                        {
                            var Cells = ResultGrid.SelectedRows[0].Cells;
                            int ID = (int)Cells["ID"].Value;
                            int Type = (int)Cells["Type"].Value;
                            switch (Type)
                            {
                                case -1:
                                    ((AdminDashboard)FindForm()).ViewScreen(new Admin(ID));
                                    break;
                                case 0:
                                    ((AdminDashboard)FindForm()).ViewScreen(new Teacher(ID));
                                    break;
                                case 1:
                                    ((AdminDashboard)FindForm()).ViewScreen(new Student(ID));
                                    break;
                            }
                        };
            button_New_User.Click += (object sender, EventArgs e) =>
             {
                 Users.CreateUser s = new Users.CreateUser();
                 ((AdminDashboard)FindForm()).AddScreen(s);
             };
            LoadResults();
        }
        public void LoadResults()
        {
            ResultGrid.DataSource = FilterSelector.GetTable();
            ResultGrid.AutoResizeColumns();
        }

    }
}
