using System;
using System.Windows.Forms;

namespace RaRat_server
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program.initController();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ra_main());
        }

        private static void initController() {
            Controller controller = new Controller();
        }
    }
}
