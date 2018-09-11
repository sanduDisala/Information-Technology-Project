using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
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
            //Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new Main.Module.Employee.mainForm());
            //Application.Run(new Main.Modules.Customer.Form1());
            //Application.Run(new Main.Modules.Inventory.InventoryMain());
           // Application.Run(new Main.Modules.Supply.Form1());
            //Application.Run(new Main.Modules.Transport.ReportViewer());
            //Application.Run(new Main.Modules.Financial.FinancialMain());
            Application.Run(new Main.Modules.Event.Form1());
        }
    }
}
