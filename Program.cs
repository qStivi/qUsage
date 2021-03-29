using System;
using System.Diagnostics;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace qUsage
{
    internal static class Program
    {
        private static DateTime _applicationStartTime;
        private static string yay;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            _applicationStartTime = DateTime.UtcNow;
            yay = "yay";
        }

        public static void Close()
        {
            MessageBox.Show(yay);
            Application.Exit();
        }
    }
}
