using System;

namespace MathOperationsApp
{
    class Program
    {
        static void Main()
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method in the class, passing in two numbers
            mathOps.PerformMathOperation(5, 10);

            // Wait for user input before exiting
            Console.ReadLine();
        }
    }
}
