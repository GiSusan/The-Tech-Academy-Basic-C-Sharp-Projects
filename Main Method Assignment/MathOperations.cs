using System;

namespace MathOperationsApp
{
    // Class containing math operations
    public class MathOperations
    {
        // Method to perform math operation on an integer
        public int PerformMathOperation(int number)
        {
            // Example math operation: multiply the number by 2
            int result = number * 2;
            return result;
        }

        // Method to perform a different math operation on a decimal
        public int PerformMathOperation(decimal number)
        {
            // Example math operation: divide the number by 2 and round down to the nearest integer
            int result = (int)(number / 2);
            return result;
        }

        // Method to perform a different math operation on a string converted to an integer
        public int PerformMathOperation(string input)
        {
            // Example math operation: square the converted integer value
            int number = Convert.ToInt32(input);
            int result = number * number;
            return result;
        }
    }
}
