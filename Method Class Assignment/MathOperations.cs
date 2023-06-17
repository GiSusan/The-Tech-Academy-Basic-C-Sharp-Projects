using System;

namespace MathOperationsApp
{
    public class MathOperations
    {
        public void PerformMathOperation(int firstNumber, int secondNumber)
        {
            // Example math operation: add the firstNumber to itself
            int result = firstNumber + firstNumber;

            // Display the secondNumber to the screen
            Console.WriteLine("Second Number: " + secondNumber);

            // Perform any additional operations or logic here
            // ...

            // Call the method within the class, passing the result and secondNumber
            DisplayResult(result, secondNumber);
        }

        public void DisplayResult(int result, int secondNumber)
        {
            // Display the result and secondNumber to the screen
            Console.WriteLine("Result: " + result);
            Console.WriteLine("Second Number: " + secondNumber);

            // Perform any additional operations or logic here
            // ...

            // Call the method within the class, passing the secondNumber and a new value
            PerformMathOperation(secondNumber, 100);
        }
    }
}
