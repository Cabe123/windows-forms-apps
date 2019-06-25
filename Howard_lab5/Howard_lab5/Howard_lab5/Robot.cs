using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

/*
    * Author: Caleb Howard 
    * Date: 11/07/2018
    * File: Robot.cs
    * The following class is used to create a Robot object that can change directions and move while tracking its position.
 */


namespace Howard_lab5
{
    class Robot
    {

        public delegate void RangeLimitEventHandler(object source, EventArgs args);

        public event RangeLimitEventHandler RangeLimitHit;

        private Point position = new Point();
        public string direction;
       
        public Robot() {

            direction = "North";
            position.X = 0;
            position.Y = 0;

            Console.WriteLine(position.X + " and " + position.Y);
        }

        // This method moves the robot towards it's current direction
        public void Move(int units) {

            // Checks which direction the robot facing
            switch (direction)
            {
                case "North":
                    position.Y += units; 
                    break;
                case "East":
                    position.X += units;
                    break;
                case "South":
                    position.Y -= units;
                    break;
                case "West":
                    position.X -= units;
                    break;
            }
            
            // Checks if the robot is going out of range. If so it raises an event.
            if (position.X >= 101 || position.Y >= 101 || position.X <= -101 || position.Y <= -101) {
                // Raises the RangeLimitHit event
                OnRangeLimitHit();
            }

        }

        // This method changes the robots direction
        public void ChangeDirection(string direction) {

            this.direction = direction;

        }

        // This method returns the appropriate arrow direction for the robot
        public string GetRobotLabel() {
            switch (direction)
            {
                case "North":
                    return Convert.ToChar(233).ToString();
                case "East":
                    return Convert.ToChar(232).ToString();
                case "South":
                    return Convert.ToChar(234).ToString();
                case "West":
                    return Convert.ToChar(231).ToString();
                     
            }
            return " ";
        }

       
        // This property is used to set and get the robots position
        public Point Position {
            get { return position; }
            set { position = value; }
        }


        // This method is responsible for notifying the subscribers of the RangeLimitHit event
        protected virtual void OnRangeLimitHit() {

            if (RangeLimitHit != null) {
                RangeLimitHit(this, EventArgs.Empty);
            }
        }

    }

}
