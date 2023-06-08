using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes an input from the user
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            // Multiplies the input by 50
            // Converts the input to a decimal for accurate multiplication
            decimal result1 = Convert.ToDecimal(input) * 50;

            // Prints the result to the console
            Console.WriteLine("Result 1: " + result1);

            // Adds 25 to the input
            // Converts the input to an int for integer addition
            int result2 = Convert.ToInt32(input) + 25;

            // Prints the result to the console
            Console.WriteLine("Result 2: " + result2);

            // Divides the input by 12.5
            // Converts the input to a double for floating-point division
            double result3 = Convert.ToDouble(input) / 12.5;

            // Prints the result to the console
            Console.WriteLine("Result 3: " + result3);

            // Checks if the input is greater than 50
            // Converts the input to an int for comparison
            bool result4 = Convert.ToInt32(input) > 50;

            // Prints the true/false result to the console
            Console.WriteLine("Result 4: " + result4);

            // Divides the input by 7 and calculates the remainder
            // Converts the input to an int for remainder calculation
            int result5 = Convert.ToInt32(input) % 7;

            // Prints the remainder to the console
            Console.WriteLine("Result 5: " + result5);

            Console.ReadLine();
        }
    }
}
