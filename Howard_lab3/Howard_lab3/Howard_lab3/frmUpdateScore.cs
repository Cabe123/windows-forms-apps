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
    * The following code creates a form that allows the user to update a specific student score.
*/

namespace Howard_lab3
{
    public partial class frmUpdateScore : Form
    {
        // Below is an object that stores data about a student's score
        class Score
        {

            string score;

            public Score()
            {

            }

            public Score(string score)
            {
                this.score = score;
            }

            public void SetScore(string score)
            {
                this.score = score;
            }

            public override string ToString()
            {
                return score;
            }

        }

        Score updatedScore = new Score();

        public frmUpdateScore(string score)
        {
            InitializeComponent();
            this.Tag = updatedScore;
            scoreTextBox.Text = score;
        }

        // Validates input to insure that only numbers from 1-100 and be entered
        private void scoreTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        // Sets the text from the text box to the score object
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (scoreTextBox.Text != "")
            {
                updatedScore.SetScore(scoreTextBox.Text);
            }
        }
    }
}
