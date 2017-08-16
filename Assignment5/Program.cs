using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name:Nirojan Kalaimannan
 *  Student Number:300606595
 * Date: Aug 13, 2017
 * Description: This is the driver class
 * Version: 0.3 - created an instance of the BMICalculatorForm object
 */
namespace Assignment5
{
    static class Program
    {
        // Create reference to Forms
        public static BMICalculator bmiForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Instanitiated new object of type BMICalculator form
            bmiForm = new BMICalculator(); 
            Application.Run(new SplashForm());
        }
    }
}
