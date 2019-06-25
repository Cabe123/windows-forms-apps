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
    * The following code creates a form that allows the user to update student information by adding, updating, and deleting student scores.
*/

namespace Howard_lab3
{
    public partial class frmUpdateStudent : Form
    {
        // Below is an object that stores student info that is then sent to the parent form
       public class StudentInfo{

            string studentInfo = "Empty";

            public StudentInfo() {

            }

            public void SetInfo(string name, List<int> scores) {
                studentInfo = name;

                foreach (int score in scores) {
                    studentInfo += "|" + score;
                }

            }

            public override string ToString()
            {
                return studentInfo;
            }

        }

        
        public string studentInfo;
        public List<int> scores = new List<int>();
        public string name;
        public StudentInfo updatedInfo = new StudentInfo();

   
        public frmUpdateStudent(string studentInfo)
        {
            InitializeComponent();

            this.Tag = updatedInfo;

            
            this.studentInfo = studentInfo;
            // Sets up the students info
            SetScoresAndName(this.studentInfo);

            foreach (int score in scores) {
                scoresListBox.Items.Add(score);
            }

            nameTextBox.Text = name;
            

        }

        // Gets the student's scores
        private void SetScoresAndName(string info)
        {

            List<string> studentInfo = info.Split('|').ToList<string>();

            // Sets name
            name = studentInfo[0];

            // Removes the student's name
            studentInfo.RemoveAt(0);

            foreach (string score in studentInfo)
            {

                scores.Add(Convert.ToInt16(score.Trim()));

            }

        }

        // Removes the select score
        private void removeBtn_Click(object sender, EventArgs e)
        {
            int index = scoresListBox.SelectedIndex;
            if (index > -1){
                scoresListBox.Items.RemoveAt(index);
                scores.RemoveAt(index);
            }
        }
        // Clears all the scores
        private void clearButton_Click(object sender, EventArgs e)
        {
            scores.Clear();
            scoresListBox.Items.Clear();
        }
        // Displays a form to add a score
        private void addBtn_Click(object sender, EventArgs e)
        {
            frmAddScore addForm = new frmAddScore();

            DialogResult buttonPressed = addForm.ShowDialog();
            if (buttonPressed == DialogResult.OK) {
                if (addForm.Tag.ToString() != null)
                {
                    scoresListBox.Items.Add(addForm.Tag.ToString());
                    scores.Add(Convert.ToInt16(addForm.Tag.ToString()));
                }
            }

        }
        // Displays a form to update a selected form
        private void updateBtn_Click(object sender, EventArgs e)
        {
            int index = scoresListBox.SelectedIndex;

            if (index != -1)
            {
                frmUpdateScore updateForm = new frmUpdateScore(scoresListBox.Text);

                DialogResult buttonPressed = updateForm.ShowDialog();
                if (buttonPressed == DialogResult.OK)
                {
                    scoresListBox.Items.RemoveAt(index);
                    scores.RemoveAt(index);
                    scoresListBox.Items.Insert(index, updateForm.Tag.ToString());
                    scores.Insert(index, Convert.ToInt16(updateForm.Tag.ToString()));
                }
            }

        }
        // Sets the updated student info to the StudentInfo object
        private void okBtn_Click(object sender, EventArgs e)
        {
            updatedInfo.SetInfo(name, scores);
        }
    }
}
