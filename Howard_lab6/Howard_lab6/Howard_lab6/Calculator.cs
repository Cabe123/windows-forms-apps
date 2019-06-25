using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    * Author: Caleb Howard
    * Date: 10/29/2018
    * The following code is used for creating a Calculator object that manages inputted values in order to properly compute them. 
*/


namespace Howard_lab6
{
    public class Calculator
    {
        private decimal currentValue;
        private decimal operand1;
        private decimal operand2;
        private enum Operator {Add, Subtract, Multiply, Divide, None };
        private Operator op;

        // Calculator constuctor
        public Calculator() {
            op = Operator.None;
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
 
        }

        // This method assigns the first operand and sets the operator to Add
        public void Add(decimal displayValue) {
     
            operand1 = displayValue;
            CurrentValue = displayValue;
            op = Operator.Add;

        }
        // This method assigns the first operand and sets the operator to Subtract
        public void Subtract(decimal displayValue)
        {

            operand1 = displayValue;
            CurrentValue = displayValue;
            op = Operator.Subtract;

        }
        // This method assigns the first operand and sets the operator to Multiply
        public void Multiply(decimal displayValue)
        {

            operand1 = displayValue;
            CurrentValue = displayValue;
            op = Operator.Multiply;

        }
        // This method assigns the first operand and sets the operator to Divide
        public void Divide(decimal displayValue)
        {

            operand1 = displayValue;
            CurrentValue = displayValue;
            op = Operator.Divide;

        }

        // This method is used for doing calculations without a new value
        public void Equals() {

            // switch for determining the correct operation to do
            switch (op)
            {
                case Operator.Add:
                    {
                        CurrentValue = operand1 + operand2; // Add
                        break;
                    }
                case Operator.Subtract:
                    {
                        CurrentValue = operand1 - operand2; // Subtract
                        break;
                    }
                case Operator.Divide:
                    {
                        try
                        {
                            CurrentValue = operand1 / operand2; // Divide
                        }
                        catch (DivideByZeroException e)
                        {  // Catches exception if the user tries divide by 0
                            MessageBox.Show("Error: You cannot divide by 0.");
                        }
                        break;
                    }
                case Operator.Multiply:
                    {
                        CurrentValue = operand1 * operand2; // Multiply
                        break;
                    }
                case Operator.None:
                    {
                        break;
                    }

            }
            operand1 = currentValue; 
        }

        // // This method is used for doing calculations with a new value
        public void Equals(decimal displayValue) {

            operand2 = displayValue;
            
            // switch for determining the correct operation to do
            switch (op)
            {
                case Operator.Add: {
                        CurrentValue = operand1 + operand2; // Add
                        break;
                }
                case Operator.Subtract: {
                        CurrentValue = operand1 - operand2; // Subtract
                        break;
                }
                case Operator.Divide: {
                        try
                        {
                            CurrentValue = operand1 / operand2; // Divide
                        }
                        catch (DivideByZeroException e)
                        {   // Catches exception if the user tries divide by 0
                            MessageBox.Show("Error: You can not divide by 0.");
                        }
                        break;
                }
                case Operator.Multiply:{
                        CurrentValue = operand1 * operand2; // Multiply    
                        break;
                }
                case Operator.None:{
                        break;
                    }
                
            }

            operand1 = CurrentValue;

        }

        // This method clears all the private fields
        public void Clear() {
            op = Operator.None;
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
        }

        //  Current value property
        public decimal CurrentValue {

            get { return currentValue; }

            set { currentValue = value; }

        }

    }
}
