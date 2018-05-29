using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Components.Admin_UI.Groups
{
    public partial class Profile : MetroFramework.Controls.MetroUserControl
    {
        public Profile():this(1)
        {
        }
        public Profile(int ID)
        {
            InitializeComponent();
        }
    }
}
