using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GystClient.AdminScreens
{
    public partial class EditLesson : Form
    {
        public EditLesson(int day,int period)
        {
            InitializeComponent();
            CreateDayLabel(day);
            CreatePeriodLabel(period);
        }
        private void CreateDayLabel(int day)
        {
            //Insert Day Data
            Controls.Add(new Label()
            {
                Name = "label_day",
                ForeColor = Color.Blue,
                AutoSize = true,
                TabIndex = 0,
                Location = new Point(label_day_title.Size.Width + label_day_title.Location.X, label_day_title.Location.Y),
                Text = Methods.GetDayName(day),
                TextAlign = ContentAlignment.MiddleCenter
            });
        }
        private void CreatePeriodLabel(int period)
        {
            //Insert Period Data
            Controls.Add(new Label()
            {
                Name = "label_period",
                ForeColor = Color.Blue,
                AutoSize = true,
                TabIndex = 0,
                Location = new Point(label_period_title.Size.Width + label_period_title.Location.X, label_period_title.Location.Y),
                Text = Methods.ToIndexingNumber(period),
                TextAlign = ContentAlignment.MiddleCenter
            });
        }
        private void label_group_Click(object sender, EventArgs e)
        {

        }
    }
}
