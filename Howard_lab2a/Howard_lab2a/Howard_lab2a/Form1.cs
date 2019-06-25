/*
   * Author: Caleb Howard
   *   Date: 9/25/2018
   *   The following code is used to calculate and display temperature conversions, i.e., Celsius to Fahrenheit and vice versa. 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Howard_lab2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal ConvertToFahrenheit() {

            decimal fahrenheit = 0.00m;

            try
            {
                // Gets input from textbox.
                decimal celsius = Convert.ToDecimal(tempInputTextBox.Text);

                // Converts Celsius to Fahrenheit.
                fahrenheit = celsius * 9 / 5 + 32;

            }
            catch (OverflowException e)
            {
                // Promts user that their number is to large.
                MessageBox.Show("ERROR: Too large of a number\n Please use a smaller number.\n\n Example: 55");
            }
            catch (FormatException e)
            {
                // Promts user that their input is invalid.
                MessageBox.Show("ERROR: Invalid input\nYour input must be a number.\n\n Example: 67.4");
            }
            catch (Exception e) {
                // Promts user that their input is invalid.
                MessageBox.Show("ERROR: Invalid input\nYour input must be a number.\n\n Example: 67.4");
            }

            return fahrenheit;
        }

        private decimal ConvertToCelsius()
        {
            decimal celsius = 0.00m;

            try
            {
                // Gets input from textbox.
                decimal fahrenheit = Convert.ToDecimal(tempInputTextBox.Text);
                // Converts Fahrenheit to Celsius.
                celsius = (fahrenheit - 32) * 5/9;

            }
            catch (OverflowException e)
            {
                // Promts user that their number is to large.
                MessageBox.Show("ERROR: Too large of a number\n Please use a smaller number.\n\n Example: 55");
            }
            catch (FormatException e)
            {
                // Promts user that their input is invalid.
                MessageBox.Show("ERROR: Invalid input\nYour input must be a number.\n\n Example: 67.4");
            }
            catch (Exception e)
            {
                // Promts user that their input is invalid.
                MessageBox.Show("ERROR: Invalid input\nYour input must be a number.\n\n Example: 67.4");
            }

            return celsius;
        }

        private void convertToFahrenheitButton_Click(object sender, EventArgs e)
        {
            // Sets the temperature output box to Fahrenheit value. 
            tempOutputTextBox.Text = ConvertToFahrenheit().ToString("n");

        }

        private void convertToCelsiusButton_Click(object sender, EventArgs e)
        {
            // Sets the temperature output box to Celsius value.
            tempOutputTextBox.Text = ConvertToCelsius().ToString("n");
        }
    }
}
