using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALOrg.Component;

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
            if (!Properties.Settings.Default.Remember)
            {
                LoginForm c = new LoginForm();
                Application.Run(c);
            }
            else
            {
                user = new User(DALOrg.UserMethods.GetUser(Properties.Settings.Default.SavedUsername, Properties.Settings.Default.SavedPassword));
                Application.Run(new Dashboard());
            }
        }
    }
}
