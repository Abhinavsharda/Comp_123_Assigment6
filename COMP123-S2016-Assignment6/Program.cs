using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Assignment6
{
   public static class Program
    {
        public static BmiCalculator FirstForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FirstForm = new BmiCalculator();
            Application.Run(FirstForm);
        }
    }
}
