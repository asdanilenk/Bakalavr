using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RegressionViewer.Forms;

namespace RegressionViewer
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
            TreeForm f1 = new TreeForm();
            Application.Run(f1);
            ConnectionManager.CloseConnection();
        }
    }
}
