using System;
using System.Windows.Forms;
namespace W03_Mega_Desk_Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }
    }
}