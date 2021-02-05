using System;
using System.Windows.Forms;
using Sudoroyal.Views.Screen;

namespace Sudoroyal
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
            Application.Run(new Splash()); // To run the Splash screen.
            Application.Run(new Title());
        }
    }
}