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
    * Date: 10/7/2018
    * The following code creates a form that allows the user to add a score to a student's record.
*/

namespace Howard_lab3
{
    public partial class frmAddScore : Form
    {
        // Below is an object that is used to hold data about a student's score
        class Score {

            string score;

            public Score()
            {
                
            }

            public Score(string score) {
                this.score = score;
            }

            public void SetScore(string score) {
                this.score = score;
            }

            public override string ToString()
            {
                return score;
            }

        }
        // Creates a new score
        Score currentScore = new Score();

        public frmAddScore()
        {
            InitializeComponent();
            // assigns this form's Tag property to the Score object
            this.Tag = currentScore;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Validates input to insure that only numbers from 1-100 and be entered
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (sender as TextBox);
            int length = textBox.Text.Length;
            string text = textBox.Text;
            // checks if the input is not a digit or control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            
            // Checks the number 1 is at index 0 and if the number 0 is at index 1
            if (text.IndexOf('1') == 0 && text.IndexOf('0') == 1)
            {
                // Checks if the input is not a 0 or a backspace
                if (e.KeyChar != Convert.ToChar(48) && e.KeyChar != Convert.ToChar(8))
                {
                    e.Handled = true;
                }
                // Checks if the input is not a backspace
                if (e.KeyChar != Convert.ToChar(8))
                {
                    // Checks to insure that there are no more than 3 digits
                    if (length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            // Checks if 1 is at index 0 and if the number 0 is not a index 1
            if (text.IndexOf('1') == 0 && text.IndexOf('0') != 1)
            {
                // checks if the input is not a backspace
                if (e.KeyChar != Convert.ToChar(8))
                {
                    if (length > 1)
                    {
                        e.Handled = true;
                    }
                }
            }
            // checks if the number 1 is in the text box
            if (text.IndexOf('1') == -1)
            {
                // checks if the input is not a backspace
                if (e.KeyChar != Convert.ToChar(8))
                {
                    if (length > 1)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        // If the user clicks the add button
        private void addBtn_Click(object sender, EventArgs e)
        {
            // checks if the text box not empty
            if (textBox1.Text != "") {
                currentScore.SetScore(textBox1.Text); // sets the score to the text boxes text
            }
        }
    }
}
