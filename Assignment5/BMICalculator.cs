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
 * Date: Aug 15, 2017
 * Description: This is where all the coding takes place for this assignment,
 * Version: 0.5 - Added the formclosing event handler
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
            if (HeightTextBox.Enabled == true)
            {
                HeightTextBox.Text += NumberKeysButton.Text;
            }
            if (WeightTextBox.Enabled == true)
            {
                WeightTextBox.Text += NumberKeysButton.Text;
            }

           
        }
        private void WeightTextBox_Click(object sender, EventArgs e)
        {
            OneButtton.Show();
            TwoButton.Show();
            ThreeButton.Show();
            FourButton.Show();
            FiveButton.Show();
            SixButton.Show();
            SevenButton.Show();
            EightButton.Show();
            NineButton.Show();
            BackSpaceButton.Show();
            WeightTextBox.Enabled = true;
            HeightTextBox.Enabled = false;
        }
        private void HeightTextBox_Click(object sender, EventArgs e)
        {
            OneButtton.Show();
            TwoButton.Show();
            ThreeButton.Show();
            FourButton.Show();
            FiveButton.Show();
            SixButton.Show();
            SevenButton.Show();
            EightButton.Show();
            NineButton.Show();
            BackSpaceButton.Show();
            HeightTextBox.Enabled = true;
            WeightTextBox.Enabled = false;

        }

        /// <summary>
        /// This is the private _backspace method. It deletes the previous number key entered by the user
        /// </summary>
        /*private void _backspace()
        {
            HeightTextBox.Text = HeightTextBox.Text.Remove(HeightTextBox.Text.Length - 1, 1);
            //WeightTextBox.Text = WeightTextBox.Text.Remove(WeightTextBox.Text.Length -1,1);
        }
        */
        /// <summary>
        /// This is the where the reset button clears all the current information in each text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {   
            WeightTextBox.Clear();
            HeightTextBox.Clear();
            BMIResultTextBox.Clear();
            MetricRadioButton.Checked = false;
            ImperialRadioButton.Checked = true;
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
        /// <summary>
        /// Coding behind the backspace button on the calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _backspace(object sender, EventArgs e)
        {
            if (HeightTextBox.Text == "" && WeightTextBox.Text == "")
            {
                BackSpaceButton.Enabled=false;
            }
            if (HeightTextBox.Text.Length > 0)
            {
                HeightTextBox.Text = HeightTextBox.Text.Remove(HeightTextBox.Text.Length - 1, 1);
            }
            if (WeightTextBox.Text.Length > 0)
            {
                WeightTextBox.Text = WeightTextBox.Text.Remove(WeightTextBox.Text.Length - 1, 1);
            }
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            ImperialRadioButton.Checked=true;
            BackSpaceButton.Hide();
            ZeroButton.Hide();
            OneButtton.Hide();
            TwoButton.Hide();
            ThreeButton.Hide();
            FourButton.Hide();
            FiveButton.Hide();
            SixButton.Hide();
            SevenButton.Hide();
            EightButton.Hide();
            NineButton.Hide();
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
