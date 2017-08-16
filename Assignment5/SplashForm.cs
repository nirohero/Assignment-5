using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name:Nirojan Kalaimannan
 *  Student Number:300606595
 * Date: Aug 15, 2017
 * Description: This is the splash form
 * Version: 0.3 - Refactored the SplashFormTimer "Tick" handler
 */
namespace Assignment5
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the "Tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            
            Program.BmiForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false; // turn timer off
        }
    }
}
