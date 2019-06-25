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
    * Author: Caleb Howard
    * Date: 11/16/2018
    * Form1.cs
    * The following code is used for managing and displaying a memory calculator form.
*/


namespace Howard_lab6
{
    public partial class Form1 : Form
    {
        // MemoryCalculator object
        MemoryCalculator calc = new MemoryCalculator();

        // Variable used to determine if a new value has been inputted
        bool newInput = false;

        public Form1()
        {
            InitializeComponent();
            
        }

        // Input buttons event handler
        private void button_Click(object sender, EventArgs e)
        {

            if (outputTextBox.Text == "0")
            {
                ClearText();
            }

            Button button = (Button)sender;

           
            if (button.Text != ".")
            {
                outputTextBox.Text += button.Text;
                newInput = true;
                
            }
            else if (!outputTextBox.Text.Contains(".")) // ensures that only one decimal can be entered
            {
                outputTextBox.Text += button.Text;
            }
            
            

        }

        // Add button event handler
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!TextIsEmpty())
            {
                calc.Add(Convert.ToDecimal(outputTextBox.Text));
                ClearText();

                newInput = true;
            }
        }
        // Divide button event handler
        private void divideButton_Click(object sender, EventArgs e)
        {
            if (!TextIsEmpty())
            {
                calc.Divide(Convert.ToDecimal(outputTextBox.Text));
                ClearText();

                newInput = true;
            }
        }
        // Multiply button event handler
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (!TextIsEmpty())
            {
                calc.Multiply(Convert.ToDecimal(outputTextBox.Text));
                ClearText();

                newInput = true;
            }
        }
        // Subtract button event handler
        private void subtractButton_Click(object sender, EventArgs e)
        {
            if (!TextIsEmpty())
            {
                calc.Subtract(Convert.ToDecimal(outputTextBox.Text));
                ClearText();

                newInput = true;
            }
        }

        // Method used to clear the output textbox
        private void ClearText() {
            outputTextBox.Text = "";
        }


        // Equals button event handler
        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (!TextIsEmpty()) // checks if the output textbox is not empty
            {
                if (newInput) // checks if there was a new value inputted
                {
                    calc.Equals(Convert.ToDecimal(outputTextBox.Text));// Calls new value equals method
                    outputTextBox.Text = calc.CurrentValue.ToString();
                    newInput = false;
                }
                else {
                    calc.Equals();
                    outputTextBox.Text = calc.CurrentValue.ToString(); // Calls no new value equals method
                }
            }
        }

        // method used to check if the textbox is empty
        private bool TextIsEmpty() {
            if (outputTextBox.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Event handler for the back button
        private void backButton_Click(object sender, EventArgs e)
        {
            string text = outputTextBox.Text;
            if (!TextIsEmpty())
            {
                // removes the last value in the string and updates the text
                outputTextBox.Text = text.Remove(text.Length - 1);
            }

            newInput = true;
        }

        // Event handler for the clear button
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clears the textbox text and the calculator fields
            ClearText();
            calc.Clear();
            newInput = true;
        }

        // Event handler for the square root button
        private void sqrtButton_Click(object sender, EventArgs e)
        {
            if (!TextIsEmpty())
            {
                decimal number = Convert.ToDecimal(outputTextBox.Text);

                double sqrt = Math.Sqrt(Convert.ToDouble(number)); // calculates the square root

                number = Convert.ToDecimal(sqrt);

                calc.CurrentValue = number; // assigns new number to the current value
                
                outputTextBox.Text = calc.CurrentValue.ToString(); // updates the textbox
            }
        }

        // Event handler for the swap button
        private void swapButton_Click(object sender, EventArgs e)
        {
            if (!TextIsEmpty())
            {
                decimal number = Convert.ToDecimal(outputTextBox.Text);

                number *= -1; // multiplies the number by -1

                calc.CurrentValue = number; // assigns new number to the current value

                outputTextBox.Text = calc.CurrentValue.ToString(); // updates the textbox
            }
        }

        // Event handler for the reciprocal button
        private void reciprocalButton_Click(object sender, EventArgs e)
        {
            if (!TextIsEmpty())
            {
                decimal number = Convert.ToDecimal(outputTextBox.Text);

                number = 1 / number; // calculates the reciprocal of the number

                calc.CurrentValue = number; // assigns new number to the current value

                outputTextBox.Text = calc.CurrentValue.ToString(); // updates the textbox
            }

        }


        // Event handler for the memory store button
        private void MS_Btn_Click(object sender, EventArgs e)
        {
            if (!TextIsEmpty())
            {
                calc.MemoryStore(Convert.ToDecimal(outputTextBox.Text));
                memoryTextBox.Text = "M";
            }
        }

        // Event handler for the memory recall button
        private void MR_BTn_Click(object sender, EventArgs e)
        {
            calc.MemoryRecall();
            outputTextBox.Text = calc.CurrentValue.ToString();
        }

        // Event handler for the memory plus button
        private void MPlus_Btn_Click(object sender, EventArgs e)
        {
            if (!TextIsEmpty())
            {
                calc.MemoryAdd(Convert.ToDecimal(outputTextBox.Text));
                memoryTextBox.Text = "M";
            }
        }

        // Event handler for the memory clear button
        private void MC_Btn_Click(object sender, EventArgs e)
        {
            calc.ClearMemory();
            memoryTextBox.Text = "";
        }
    }
}
