using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Components.Teacher_UI.Assignments
{
    public partial class ViewAssignments : MetroFramework.Controls.MetroUserControl
    {
        public ViewAssignments()
        {
            InitializeComponent();
            DAL.Component.Filter.Filter FTeacher = DAL.Component.Filter.Filter.CloneWithValue(DAL.Component.Filter.Filters.Assignment.TeacherID, Program.user.ID.ToString());
            string Tablename = DAL.Component.Data.Assignment.Tablename;
            string[] Columns = DAL.Component.Data.Assignment.Columns;
            Columns[0] = Columns[0] + " As ID";
            ResultGrid.AutoResizeColumns();
            ResultGrid.DataSource = DAL.Methods.GetFilteredTable(Tablename,Columns, FTeacher);
            ResultGrid.CellDoubleClick += (object sender, DataGridViewCellEventArgs e) =>
            {
                var Cells = ResultGrid.SelectedRows[0].Cells;
                int ID = (int)Cells["ID"].Value;
                ((TeacherDashboard)FindForm()).ViewScreen(new Profile(ID));
            };
            button_New_Assignment.Click += (object sender, EventArgs e) =>{
                ((TeacherDashboard)FindForm()).ViewScreen(new Create());
            };
        }
    }
}
