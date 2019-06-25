using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

/*
    * Author: Caleb Howard 
    * Date: 11/07/2018
    * File: Form1.cs
    * The following code is used to display a Robot object that the user can move around the screen.
 */

namespace Howard_lab5
{
    public partial class Form1 : Form
    {
        Robot robot = new Robot();

        private int xCenter;
        private int yCenter;

        public Form1()
        {

            InitializeComponent();

            robotLabel.Text = robot.GetRobotLabel();

            robot.RangeLimitHit += this.OnRangeLimitHit;

            xCenter = (panel1.Width / 2) - (robotLabel.Width / 2);
            yCenter = (panel1.Height / 2) - (robotLabel.Height / 2);

            robotLabel.Location = new Point(xCenter, yCenter);

        }

        // This is the event handler for the RangeLimitHit event
        public void OnRangeLimitHit(object source, EventArgs e) {
            MessageBox.Show("You have hit the robot's range limit.");
            robot.Move(-10);
            DisplayRobotPosition();
        }

        // North button
        private void northButton_Click(object sender, EventArgs e)
        {
            robot.ChangeDirection("North");
            robotLabel.Text = robot.GetRobotLabel();
        }

        // East button
        private void eastButton_Click(object sender, EventArgs e)
        {
            robot.ChangeDirection("East");
            robotLabel.Text = robot.GetRobotLabel();
        }

        // South button
        private void southButton_Click(object sender, EventArgs e)
        {
            robot.ChangeDirection("South");
            robotLabel.Text = robot.GetRobotLabel();
        }


        // West button
        private void westButton_Click(object sender, EventArgs e)
        {
            robot.ChangeDirection("West");
            robotLabel.Text = robot.GetRobotLabel();
        }
         
 
        // Go 1 unit button
        private void goOneButton_Click(object sender, EventArgs e)
        {
            robot.Move(1);
            positionLabel.Text = "{X=" + robot.Position.X + ",Y=" + robot.Position.Y + "}";
            DisplayRobotPosition();
        }

        // Go 10 units button
        private void goTenButton_Click(object sender, EventArgs e)
        {
            robot.Move(10);
            positionLabel.Text = "{X=" + robot.Position.X + ",Y=" + robot.Position.Y + "}";
            DisplayRobotPosition();
        }

        // This method updates the robot's position relative to the form's panel 
        private void DisplayRobotPosition() {

            robotLabel.Location = new Point(xCenter + (robot.Position.X), yCenter + (robot.Position.Y * -1));

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
