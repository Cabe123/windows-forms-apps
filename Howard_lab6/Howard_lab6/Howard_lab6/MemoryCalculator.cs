using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  * Author: Caleb Howard
  * Date: 11/16/2018
  * File: MemoryCalculator.cs
  * The following class is used to create a MemoryCalculator object. The class inherits from Calculator.cs and adds the ability to
  * store values into a memory variable.
*/

namespace Howard_lab6
{
    class MemoryCalculator : Calculator
    {

        private decimal memoryValue;

        // Constructor
        public MemoryCalculator()
        {
            memoryValue = 0;    
        }


        // This method takes the current value displayed on the calculator and stores it into memory.
        public void MemoryStore(decimal displayValue)
        {
            memoryValue = displayValue;
        }


        // This method sets the calculator's CurrentValue property to the value stored in memory.
        public void MemoryRecall()
        {
            this.CurrentValue = memoryValue;
        }


        // This method adds the value displayed on the calculator to the value stored in memory.
        public void MemoryAdd(decimal displayValue)
        {
            memoryValue += displayValue;
        }


        // This method clears the value stored in memory.
        public void ClearMemory()
        {
            memoryValue = 0;
        }

    }
}
