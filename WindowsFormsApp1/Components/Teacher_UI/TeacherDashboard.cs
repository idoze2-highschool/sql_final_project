using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Client.Components.Teacher_UI
{
    public partial class TeacherDashboard : MetroForm
    {
        public TeacherDashboard()
        {
            InitializeComponent();
            InitializeMenuButtons();
            ClickButton(button_Select_Dashboard);
        }
        private void InitializeMenuButtons()
        {
            button_Select_Dashboard.Tag = new Dashboard.LandingPage();
            button_Select_Grades.Tag = new Assignments.Create();
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button_Logout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Remember = false;
            Properties.Settings.Default.Save();
            Close();
            Application.Restart();
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            ClickButton((Button)sender);
        }
        public void ClickButton(Button button)
        {
            foreach (Button b in panel_MenuButtons.Controls.OfType<Button>())
            {
                b.BackColor = Color.FromArgb(70, 30, 145, 79);
                b.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, b.BackColor);
                b.FlatAppearance.MouseDownBackColor = b.FlatAppearance.MouseOverBackColor;
            }
            button.BackColor = Color.FromArgb(205, 30, 145, 79);
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, button.BackColor);
            button.FlatAppearance.MouseDownBackColor = button.FlatAppearance.MouseOverBackColor;
            ViewScreen((MetroFramework.Controls.MetroUserControl)(button.Tag));

        }
        public void ViewScreen(MetroFramework.Controls.MetroUserControl Screen)
        {
            panel_ViewArea.Controls.Clear();
            panel_ViewArea.Controls.Add(Screen);
            panel_ViewArea.Controls[0].Focus();
        }
        public void AddScreen(MetroFramework.Controls.MetroUserControl Screen)
        {
            panel_ViewArea.Controls[panel_ViewArea.Controls.Count - 1].Hide();
            panel_ViewArea.Controls.Add(Screen);
            Screen.Disposed += (object sender, EventArgs e) =>
             {
                 Controls.Remove(Screen);
                 panel_ViewArea.Controls[panel_ViewArea.Controls.Count - 1].Show();
             };
        }
        //private void AdminDashboard_SizeChanged(object sender, EventArgs e) {MessageBox.Show("sender: "+sender.ToString() + ", e: " + e.ToString());}
    }
}
