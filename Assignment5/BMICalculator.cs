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
 * Student Number:300606595
 * Date: Aug 14, 2017
 * Description: This is where all the coding takes place for this assignment,
 * Version: 0.3 - Started implementing calculations with the BMICalculate button
 */
namespace Assignment5
{
    public partial class BMICalculator : Form
    {
        //PRIVATE INSTANCE VARIABLES
       
        
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
            //WeightTextBox.Text += NumberKeysButton.Text;
        }
        /// <summary>
        /// This is the private _backspace method. It deletes the previous number key entered by the user
        /// </summary>
        private void _backspace()
        {
            WeightTextBox.Text = WeightTextBox.Text.Remove(WeightTextBox.Text.Length -1,1);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            
            WeightTextBox.Clear();
            HeightTextBox.Clear();
            BMIResultTextBox.Clear();
        }
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //keep
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MetricRadioButton.Checked) { MetersLabel.Text = "m"; KilogramsLabel.Text = "kg"; }
            if (ImperialRadioButton.Checked) { MetersLabel.Text = "in"; KilogramsLabel.Text = "lbs";} 

        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            //Variables created to do calculations from the height and width textboxs
            double height = Convert.ToDouble(HeightTextBox.Text);
            double weight = Convert.ToDouble(WeightTextBox.Text);
            double bmi;
            if (MetricRadioButton.Checked)
            {
                bmi =weight/Math.Pow(height,2);
                BMIResultTextBox.Text = bmi.ToString(); 
            }
            if (ImperialRadioButton.Checked)
            {
                bmi =weight*703/Math.Pow(height,2);
                BMIResultTextBox.Text = bmi.ToString();
            }
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
