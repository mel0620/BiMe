using System;
using System.Windows.Forms;
using Biometrics;

namespace BioMetrixCore
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
            Application.Run(new Master());
            //Application.Run(new frmProgress());
           // Application.Run(new Log_Viewer());
        }
    }
}
