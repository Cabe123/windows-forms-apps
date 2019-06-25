/*
  * Author: Caleb Howard 
  *   Date: 9/16/2018
  *   The following code is used for calculating and displaying the price of an automotive repair.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Howard_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private decimal OilLubeCharges()
        {
            decimal charges = 0.00m;
            // Checks if the user wants an oil change.
            if (oilChangeCheckBox.Checked)
                charges += 26.00m;
            // Checks if the user wants a lube job.
            if (lubeJobCheckBox.Checked)
                charges += 18.00m;

            return charges;
        }

        private decimal FlushCharges()
        {
            decimal charges = 0.00m;
            // Checks if the user wants a radiator flush.
            if (radFlushCheckBox.Checked)
                charges += 30.00m;
            // Checks if the user wants a transmission flush.
            if (tranFlushCheckBox.Checked)
                charges += 80.00m;

            return charges;
        }

        private decimal MiscCharges()
        {
            decimal charges = 0.00m;
            // Checks if the user wants an inspection.
            if (inspectionCheckBox.Checked)
                charges += 15.00m;
            // Checks if the user wants a muffler replacement.
            if (replaceMufflerCheckBox.Checked)
                charges += 100.00m;
            // Checks if the user wants a tire rotation.
            if (tireRotationCheckBox.Checked)
                charges += 20.00m;

            return charges;
        }

        private decimal OtherCharges()
        {
            decimal charges = 0.00m;
            // Adds the total of parts and labor charges.
            charges += PartsCharges();
            charges += LaborCharges();
            
            return charges;
        }

        private decimal TaxCharges()
        {
            decimal charges = 0.00m;
            // Calculates the tax for the parts.
            charges += PartsCharges() * 0.06m; 

            return charges;
        }

        private decimal TotalCharges()
        {
            decimal totalCharges = 0.00m;
            // Calls all the charges methods to add up the total.
            totalCharges += OilLubeCharges();
            totalCharges += FlushCharges();
            totalCharges += MiscCharges();
            totalCharges += OtherCharges();
            totalCharges += TaxCharges();

            return totalCharges;
        }

        private decimal ServiceAndLaborCharges()
        {
            decimal charges = 0.00m;
            // Adds up the total service and labor charges.
            charges += OilLubeCharges() + FlushCharges() + MiscCharges();
            charges += LaborCharges();

            return charges;
        }

        private decimal PartsCharges() {

            decimal charges = 0.00m;
            // Checks if the parts textbox is not empty.
            if (partsInputTextBox.Text != "")
                charges += Convert.ToDecimal(partsInputTextBox.Text); // Converts the text to a decimal. 

            return charges;
        }

        private decimal LaborCharges() {

            decimal charges = 0.00m;
            // Checks if the labor textbox is not empty.
            if (laborTextBox.Text != "")
                charges += Convert.ToDecimal(laborTextBox.Text); // Converts the text to a decimal.

            return charges;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // Sets the text for all of the output textboxes.
            serviceAndLaborTextBox.Text = ServiceAndLaborCharges().ToString("c");
            partsOutputTextBox.Text = PartsCharges().ToString("c");
            partsTaxTextBox.Text = TaxCharges().ToString("c");
            totalFeesTextBox.Text = TotalCharges().ToString("c");
        }

        private void ClearOilLube()
        {   
            // Unchecks the oil change and lube job checkboxes.
            oilChangeCheckBox.Checked = false;
            lubeJobCheckBox.Checked = false;
        }

        private void ClearFlushes()
        {
            // Unchecks the radiator flush and transmission flush checkboxes.
            radFlushCheckBox.Checked = false;
            tranFlushCheckBox.Checked = false;
        }

        private void ClearMisc()
        {
            // Unchecks the inspection, replace muffler, and tire rotation checkboxes.
            inspectionCheckBox.Checked = false;
            replaceMufflerCheckBox.Checked = false;
            tireRotationCheckBox.Checked = false;
        }

        private void ClearOther()
        {
            // Clears the parts and labor input textboxes.
            partsInputTextBox.Text = null;
            laborTextBox.Text = null;
        }

        private void ClearFees()
        {
            // Clears all the output textboxes.
            serviceAndLaborTextBox.Text = null;
            partsOutputTextBox.Text = null;
            partsTaxTextBox.Text = null;
            totalFeesTextBox.Text = null;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Calls all the clear methods to reset everything.
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the application.
            this.Close();
        }

        private void ValidateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Checks to see if the input is not a number, decimal point, or control key.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Checks to make sure there is no more than one decimal point.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // Checks if the key is not the delete key.
            if (e.KeyChar != Convert.ToChar(8)) {
            // Checks to make sure that there are no more than two numbers after the decimal point.
                if (Regex.IsMatch((sender as TextBox).Text, @"\.\d\d"))
                {
                    // Checks to see if the SelectionStart (The index of the string where the user is about to type) is
                    // greater than the length of the text - 3. Allowing the user to input new numbers before the decimal but
                    // not after.
                    if ((sender as TextBox).SelectionStart > (sender as TextBox).TextLength - 3)
                    {
                        e.Handled = true;
                    }
                }
            }

        }

    }
}
