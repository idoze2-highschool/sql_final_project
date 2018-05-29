using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Components.Admin_UI.Groups.View_Groups
{
    public partial class Timetable : MetroFramework.Controls.MetroUserControl
    {
        public Timetable():this(0)
        {   
        }
        public Timetable(int GroupID)
        {
            InitializeComponent();
        }
    }
}
