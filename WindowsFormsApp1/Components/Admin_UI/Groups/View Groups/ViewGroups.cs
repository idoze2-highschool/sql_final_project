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
using Client.Components.Admin_UI.Groups;
using DAL.Component.Data;
using DAL.Component.Filter;

namespace Client.Components.Admin_UI.Groups
{
    public partial class ViewGroups : MetroFramework.Controls.MetroUserControl
    {
        public ViewGroups()
        {
            InitializeComponent();
            FilterSelector.Invalidated += (object sender, InvalidateEventArgs e) => { LoadResults(); };
            ResultGrid.CellDoubleClick += (object sender, DataGridViewCellEventArgs e) =>
            {
                var Cells = ResultGrid.SelectedRows[0].Cells;
                int ID = (int)Cells["ID"].Value;
                ((AdminDashboard)FindForm()).ViewScreen(new Profile(ID));

            };
            button_New_Group.Click += (object sender, EventArgs e) =>
            {
                CreateGroup s = new CreateGroup();
                ((AdminDashboard)FindForm()).ViewScreen(s);
            };
            LoadResults();
        }
        public ViewGroups(User Student):this()
        {
            FilterSelector.Hide();
            FilterSelector.ApplyFilter(Filters.Group.HasStudent, Student.ID.ToString());
            LoadResults();
            label_Title.Text = String.Format("Showing Groups That {0} Belongs To", Student.FName + " " + Student.LName[0]+".");
        }
        public void LoadResults()
        {
            ResultGrid.DataSource = FilterSelector.GetTable();
            ResultGrid.AutoResizeColumns();
        }
    }
}
