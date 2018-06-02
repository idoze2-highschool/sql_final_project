using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Component.Data;

namespace Client
{
    static class Program
    {
        internal static User user;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!Properties.Settings.Default.LoggedIn)
            {
                LoginForm c = new LoginForm();
                Application.Run(c);
                Login();
            }
            else
            {
                user = new User(DAL.UserMethods.GetUser(Properties.Settings.Default.SavedUsername, Properties.Settings.Default.SavedPassword));
                switch (Program.user.UserType)
                {
                    case -1:
                        Application.Run(new Components.Admin_UI.AdminDashboard());
                        break;
                    case 0:
                        Application.Run(new Components.Teacher_UI.TeacherDashboard());
                        break;
                    default:
                        MessageBox.Show(string.Format("Could Not Login As \"{0} {1}\" [{2}],\nThis Happened Because They're a User Of Type {3},\nAnd Can't Use The Client.\nLogging Out...",user.FName,user.LName,user.ID,user.UserType));
                        Logout();
                        Application.Restart();
                        break;
                }
                if (!Properties.Settings.Default.Remember)
                    Logout();
            }
        }
        static void Login()
        {
            Properties.Settings.Default.LoggedIn = true;
            Properties.Settings.Default.Save();
        }
        static void Logout()
        {
            Properties.Settings.Default.Remember = false;
            Properties.Settings.Default.LoggedIn = false;
            Properties.Settings.Default.Save();
        }
    }
}
