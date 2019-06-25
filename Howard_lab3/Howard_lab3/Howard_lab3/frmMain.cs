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
    * The following code creates a form that includes a list of students which the user can click on to display corresponding data regarding their scores.
    * It also allows the user to add students, delete students, and update student information.
*/

namespace Howard_lab3
{
    
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            this.Tag = studentListBox.Text;
            
            // Sample students
            studentListBox.Items.Add("Joel Murach|97|71|83");
            studentListBox.Items.Add("Doug Lowe|99|93|97|100");
            studentListBox.Items.Add("Anne Boehm|100|100|100");
        }
    
        /* Events Handlers*/

        // If the add new student button is pressed
        private void addNewBtn_Click(object sender, EventArgs e)
        {
            // Creates new form that allows the user to add a new student
            frmAddStudent addStudent = new frmAddStudent();
            // Keeps track of user response
            DialogResult buttonPressed = addStudent.ShowDialog();
            // Checks if the user wanted to add the student
            if (buttonPressed == DialogResult.OK)
                studentListBox.Items.Add(addStudent.Tag.ToString()); // adds the student info from the form's Tag property
            
        }
        // If the delete button is pressed
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Deletes the student and clears the score text boxex
            DeleteStudent();
            ClearScoreTextBoxes();
        }
        // If the user clicks on a student
        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checks if the selected exists
            if (studentListBox.SelectedItem != null)
            {
                // Displays student info in text boxes
                totalTextBox.Text = GetScoreTotal().ToString(); 
                countTextBox.Text = GetScoreCount().ToString();
                averageTextBox.Text = GetAverage().ToString();
            }
            // Checks if the number of students is 0
            if (studentListBox.Items.Count == 0)
            {
                // Clears the score text boxes
                ClearScoreTextBoxes();
            }
        }
        // If the user clicks the update student button
        private void updateBtn_Click(object sender, EventArgs e)
        {
            int index = studentListBox.SelectedIndex; // saves the selected student's index
            // Checks if the user has selected a student 
            if (index != -1)
            {
                // Create new form that allows the user to update a students scores
                frmUpdateStudent updateForm = new frmUpdateStudent(studentListBox.Text);
                // Keeps track of response
                DialogResult buttonPressed = updateForm.ShowDialog();
                // Checks if the user wanted add the student
                if (buttonPressed == DialogResult.OK)
                {
                    // Removes the student info at the selected index
                    studentListBox.Items.RemoveAt(index);
                    // Inserts the updated info at the selected index
                    studentListBox.Items.Insert(index, updateForm.Tag.ToString());
                }
            }
        }


        /* SCORE CALCULATION METHODS */


        // Gets the student's scores
        private List<int> GetScores() {

            List<int> scores = new List<int>();
            
            // Seperates student's name and scores
            List<string> studentInfo = studentListBox.Text.Split('|').ToList<string>();

            // Removes the student's name
            studentInfo.RemoveAt(0);

            // Adds all the students scores to a List
            foreach (string score in studentInfo) {

                scores.Add(Convert.ToInt16(score.Trim()));

            }

            return scores;
        }

        // Calculates and returns student's average test score
        private int GetAverage() {

            int average = 0;
            int totalScore = 0;

            // Gets the student's scores and assigns them to a list
            List<int> scores = GetScores();
            
            // Adds up the total
            foreach (int score in scores) {
                totalScore += score;
            }
            // Checks if there are scores in the list
            if (scores.Count != 0)
                average = totalScore / scores.Count; // calculates the average

            return average;
        }

        // Gets the the number of scores the student has
        private int GetScoreCount() {

            int count = 0;
            // Gets the student's scores and assigns them to a list
            List<int> scores = GetScores();

            count = scores.Count;

            return count;

        }
        // Calculates and returns the student's total score
        private int GetScoreTotal() {
            int total = 0;
            
            // Gets the student's scores and assigns them to a list
            List<int> scores = GetScores();
            
            // Adds up the student's total score
            foreach (int score in scores) {
                total += score;
            }

            return total;
        }

        // Clears all the text boxes
        private void ClearScoreTextBoxes() {
            totalTextBox.Text = null;
            countTextBox.Text = null;
            averageTextBox.Text = null;
        }

        // Deletes a selected student
        private void DeleteStudent() {

            int index = studentListBox.SelectedIndex;
            // checks if a student is selected
            if (index > -1)
                studentListBox.Items.RemoveAt(index);
        }

        
    }
}
