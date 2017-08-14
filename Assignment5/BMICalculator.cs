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
 * Date: Aug 14, 2017
 * Description: This is where all the coding takes place for this assignment,
 * Version: 0.2 - Added the private _backspace method
 */
namespace Assignment5
{
    public partial class BMICalculator : Form
    {
        //PRIVATE INSTANCE VARIABLES
       
        private bool _isResetClicked;
        //PUBLIC PROPERTIES
        public bool isResetClicked
        {
            get
            {
                return this._isResetClicked;
            }
            set
            {
                this._isResetClicked = value; 
            }
        }
        public BMICalculator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// event handler that takes in input from user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeysButton_Click(object sender, EventArgs e)
        {
            Button NumberKeysButton = sender as Button; // downcasting

            switch (NumberKeysButton.Text)
            {
                case "⌫":
                    this._backspace();
                    break;
            }
            HeightTextBox.Text +=NumberKeysButton.Text;
            WeightTextBox.Text += NumberKeysButton.Text;
        }
        /// <summary>
        /// This is the private _backspace method. It deletes the previous number key by the user
        /// </summary>
        private void _backspace()
        {
            throw new NotImplementedException();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
                
        }
    }
}
