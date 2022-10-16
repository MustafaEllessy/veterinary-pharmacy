using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.S
        /// </summary>
        [STAThread]
        static void Main()
        {
            DB.open();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PharmacyMenu());
        }
    }
}
