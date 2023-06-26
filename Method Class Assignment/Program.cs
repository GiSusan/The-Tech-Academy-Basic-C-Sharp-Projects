using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 10;

            // 2- Instantiate class
            MathOperations mathOps = new MathOperations();

            // 3 -Call the method in the class, passing in two numbers
            mathOps.PerformMathOperation(number1, number2);

            // 4- Call the method in the class, specifying the parameters by name
            mathOps.PerformMathOperation(firstNumber: number1, secondNumber: number2);

            Console.ReadLine();
        }
    }
}
