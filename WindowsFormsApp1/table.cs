using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;

namespace Client
{
    public partial class table : MetroFramework.Controls.MetroUserControl
    {
        public table()
        {
            InitializeComponent();
        }

        public table(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
