using System;
using System.Collections.Generic;
using System.Windows.Forms;
using lab_inventory.Menu;

namespace lab_inventory
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
            Application.Run(new fUtama());
        }
    }
}
