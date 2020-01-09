using System;
using System.Windows.Forms;

namespace CustomManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MyGlobalClass.Domen = "dissertatsiya.kibera.uz";
            MyGlobalClass.Port = 80;

            //MyGlobalClass.Domen = "magdis.uz";
            //MyGlobalClass.Port = 80;

            //MyGlobalClass.Domen = "195.158.24.58";
            //MyGlobalClass.Port = 81;

            MyGlobalClass.DBManager = new DatabaseManager.DBManager();
            Application.Run(new LoginForm());
            if (MyGlobalClass.Customer != null)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
