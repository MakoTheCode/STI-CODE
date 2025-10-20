// Program.cs (BasicCalculator)
using System;
using System.Windows.Forms;

namespace BasicCalculator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Ensures the application runs with appropriate visual styles and message loop
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the main form (FrmBasicCalculator)
            Application.Run(new FrmBasicCalculator());
        }
    }
}
