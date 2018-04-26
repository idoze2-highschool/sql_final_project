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

namespace Client.Components.Admin_UI.Users
{
    public partial class ViewUsers : MetroFramework.Controls.MetroUserControl
    {
        public ViewUsers()
        {
            InitializeComponent();
            FilterSelector.SetComponentType(Base.Component.User);
            LoadResults();
            FilterSelector.button_Add.Click += (object sender, EventArgs e) => { LoadResults(); };
        }
        public void LoadResults()
        {
            ResultGrid.DataSource = FilterSelector.GetTable();
        }
        
    }
}
