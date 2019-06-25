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
    * The following code creates a form that allows the user to add a student to the list by inputting the student's name and scores.
*/

namespace Howard_lab3
{
    public partial class frmAddStudent : Form
    {
        private Student student = new Student();

        public frmAddStudent()
        { 
            InitializeComponent();
            this.Tag = student;
            this.DialogResult = DialogResult.OK;
        }



        //Below is an object that is used to store student data
       class Student {

            private string name;
            public List<int> scores = new List<int>();
            

            public Student(){
                name = "";
            }
            public Student(string name) {
                this.name = name;
            }

            public void SetStudentName(string name) {
                this.name = name;
            }

            public void AddStudentScore(int score){
                scores.Add(score);
            }

            public string GetScores() {
                string scoreText = "";
                foreach (int score in scores) {
                    scoreText += score + " ";
                }

                return scoreText;
            }

            public override string ToString()
            {
                string studentInfo = name;
                foreach (int score in scores) {
                    studentInfo += "|" + score;
                }
                return studentInfo;
            }

        }



        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        // Validates input for the name text box
        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = true;
            }

            if (char.IsWhiteSpace(e.KeyChar) && (sender as TextBox).Text.Length == 0) {
                e.Handled = true;
            }

            if (e.KeyChar != Convert.ToChar(8))
                if ((sender as TextBox).Text.Length > 30) {
                    e.Handled = true;
            }
        }

        // Validates input to insure that only numbers from 1-100 and be entered
        private void scoreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (sender as TextBox);
            int length = textBox.Text.Length;
            string text = textBox.Text;
            // checks if the input is not a digit or control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
            // Checks the number 1 is at index 0 and if the number 0 is at index 1
            if (text.IndexOf('1') == 0 && text.IndexOf('0') == 1){
                // Checks if the input is not a 0 or a backspace
                if (e.KeyChar != Convert.ToChar(48) && e.KeyChar != Convert.ToChar(8))
                {
                    e.Handled = true;
                }
                // Checks if the input is not a backspace
                if (e.KeyChar != Convert.ToChar(8)) {
                    // Checks to insure that there are no more than 3 digits
                    if (length > 2) {
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
            if (text.IndexOf('1') == -1){
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
        // Adds the score from the text box into the student's scores
        private void addScoreBtn_Click(object sender, EventArgs e)
        {
            if (scoreTextBox.Text != "") {
                student.AddStudentScore(Convert.ToInt16(scoreTextBox.Text));
                scoreTextBox.Text = null;
            }
            scoresOutputTextBox.Text = student.GetScores();
        }
        // Clears the student's scores
        private void clearScoresBtn_Click(object sender, EventArgs e)
        {
            student.scores.Clear();
            scoresOutputTextBox.Text = null;
        }
        
        // Insures that the user has entered a name and sets the student's name
        private void okBtn_Click(object sender, EventArgs e)
        {
            
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("You must enter the student's name.");
                this.DialogResult = DialogResult.None;
            }
            else {
                student.SetStudentName(nameTextBox.Text);
            }
        }
    }
}
