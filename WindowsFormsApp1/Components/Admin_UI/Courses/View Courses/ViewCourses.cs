using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Components.Admin_UI.Groups;

namespace Client.Components.Admin_UI.Courses
{
    public partial class ViewCourses : MetroFramework.Controls.MetroUserControl
    {
        public ViewCourses()
        {
            InitializeComponent();
            FilterSelector.Invalidated += (object sender, InvalidateEventArgs e) => { LoadResults(); };
            ResultGrid.CellDoubleClick += (object sender, DataGridViewCellEventArgs e) =>
            {
                var Cells = ResultGrid.SelectedRows[0].Cells;
                int ID = (int)Cells["ID"].Value;
                ((AdminDashboard)FindForm()).ViewScreen(new Profile(ID));
            };
            button_New_Course.Click += (object sender, EventArgs e) =>
            {
                CreateCourse s = new CreateCourse();
                ((AdminDashboard)FindForm()).ViewScreen(s);
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
