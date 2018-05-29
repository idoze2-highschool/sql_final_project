using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Components.Teacher_UI.Dashboard
{
    public partial class LandingPage : MetroFramework.Controls.MetroUserControl
    {
        public LandingPage()
        {
            InitializeComponent();
            label1.Text = label1.Text.Replace("%NAME%",Program.user.FName);
        }
    }
}
