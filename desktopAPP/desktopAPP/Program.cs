using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopAPP
{
    internal static class Program
    {
        public static Home home;
        
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            home = new Home();
            Application.Run(home);
        }
    }
}
