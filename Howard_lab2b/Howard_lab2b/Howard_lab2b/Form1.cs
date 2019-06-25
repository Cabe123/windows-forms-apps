/*
  * Author: Caleb Howard
  *   Date: 9/23/2018
  *   The following code is used to calculate and display the revenue generated from stadium tickets.
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

namespace Howard_lab2b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // Calculates the amount generated from class A tickets.
        private decimal calculateClassA() {
            decimal amount = 0.00m;
            // Checks if the textbox is not empty.
            if(classATextBox.Text != "")
                amount = Convert.ToDecimal(classATextBox.Text) * 15; 

            return amount;
        }
        
        // Calculates the amount generated from class A tickets.
        private decimal calculateClassB()
        {
            decimal amount = 0.00m;
            // Checks if the textbox is not empty.
            if (classBTextBox.Text != "")
                amount = Convert.ToDecimal(classBTextBox.Text) * 12;

            return amount;
        }
        
        // Calculates the amount generated from class A tickets.
        private decimal calculateClassC()
        {
            decimal amount = 0.00m;
            // Checks if the textbox is not empty.
            if (classCTextBox.Text != "")
                amount = Convert.ToDecimal(classCTextBox.Text) * 9; 

            return amount;
        }

        // Calulates the total amount generated from all tickets.
        private decimal calculateTotal()
        {
            decimal total = 0.00m;

            total = calculateClassA() + calculateClassB() + calculateClassC();

            return total;
        }

        private void Validate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Checks if the input is not a control or digit character. 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                // Promts user that thier input is invalid.
                MessageBox.Show("That is an invalid input. Please \nenter whole numbers only.\n\nExample: 75");
                e.Handled = true;
            }

            // Checks if the input is a number and if length of text is greater than 10.
            if (char.IsDigit(e.KeyChar) && (sender as TextBox).TextLength > 10) {
                e.Handled = true;
            }

        }

        private void ClearTextBoxes() {
            
            // Clears input textboxes.
            classATextBox.Text = null;
            classBTextBox.Text = null;
            classCTextBox.Text = null;
            
            //Clear output textboxes.
            classAOutputTextBox.Text = null;
            classBOutputTextBox.Text = null;
            classCOutputTextBox.Text = null;
            totalOutputTextBox.Text = null;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Displays the amount of revenue generated.
            classAOutputTextBox.Text = calculateClassA().ToString("c");
            classBOutputTextBox.Text = calculateClassB().ToString("c");
            classCOutputTextBox.Text = calculateClassC().ToString("c");
            totalOutputTextBox.Text = calculateTotal().ToString("c");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
