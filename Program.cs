using Blockchain_wpf_client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockchain_wpf_client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static Login loginForm;
        public static Register registerForm;
        public static main mainForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginForm = new Login();
            registerForm = new Register();
            mainForm = new main();

            Application.Run(loginForm);
        }
    }
}
