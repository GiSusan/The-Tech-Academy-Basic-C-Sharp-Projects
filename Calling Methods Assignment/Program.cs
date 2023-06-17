using System;

namespace MathOperationsApp
{
    class Program
    {
        static void Main()
        {
            // Prompt user for a number
            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Create an instance of MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call each method and display the result
            int doubledNumber = mathOps.DoubleNumber(userInput);
            Console.WriteLine("Double: " + doubledNumber);

            int squaredNumber = mathOps.SquareNumber(userInput);
            Console.WriteLine("Square: " + squaredNumber);

            int factorial = mathOps.Factorial(userInput);
            Console.WriteLine("Factorial: " + factorial);

            // Wait for user input before exiting
            Console.ReadLine();
        }
    }
}
