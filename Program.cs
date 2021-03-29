using System;
using System.Diagnostics;
using System.Globalization;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace qUsage
{
    internal static class Program
    {
        private static DateTime _applicationStartTime;

        [STAThread]
        private static void Main()
        {
            _applicationStartTime = DateTime.UtcNow;
            var list = Process.GetProcessesByName("opera");
            var test = list[1].MainModule.FileVersionInfo.InternalName;
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static void Close()
        {
            var timePassed = DateTime.UtcNow - _applicationStartTime;
            // MessageBox.Show(timePassed.ToString());
            Application.Exit();
        }
    }
}
