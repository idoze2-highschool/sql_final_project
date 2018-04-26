using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Components.Admin_UI.Users
{
    public partial class ViewUsers : MetroFramework.Controls.MetroUserControl
    {
        public ViewUsers()
        {
            InitializeComponent();
            dataFilter1.SetComponentType(Base.Component.User);
        }
        
    }
}
