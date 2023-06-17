using System;

namespace MathOperationsApp
{
    class Program
    {
        static void Main()
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the first method with an integer argument
            int integerResult = mathOps.PerformMathOperation(5);
            Console.WriteLine("Integer Result: " + integerResult);

            // Call the second method with a decimal argument
            int decimalResult = mathOps.PerformMathOperation(10.5m);
            Console.WriteLine("Decimal Result: " + decimalResult);

            // Call the third method with a string argument
            int stringResult = mathOps.PerformMathOperation("7");
            Console.WriteLine("String Result: " + stringResult);

            // Wait for user input before exiting
            Console.ReadLine();
        }
    }
}
