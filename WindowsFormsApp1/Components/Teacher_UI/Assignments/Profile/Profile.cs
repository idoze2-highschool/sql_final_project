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
    public partial class Profile : MetroFramework.Controls.MetroUserControl
    {
        public Profile():this(1)
        {
        }
        public Profile(int ID)
        {
            InitializeComponent();
            ResultGrid.AutoResizeColumns();
            ResultGrid.DataSource = DAL.Methods.GetAssignmentStudentsByID(ID);
            DAL.Component.Data.Assignment Ass = DAL.Methods.GetAssignmentByID(ID);
            label_Title.Text = Ass.AssTitle;
            label_Desc.Text = Ass.AssDesc;
            ResultGrid.Location = new Point(0,label_Desc.Bounds.Bottom);
            ResultGrid.Size = new Size(ResultGrid.Size.Width,Bounds.Bottom - ResultGrid.Bounds.Top);
            ResultGrid.Columns["Grade"].ReadOnly = false;
            ResultGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            ResultGrid.Edit
        }
    }
}
