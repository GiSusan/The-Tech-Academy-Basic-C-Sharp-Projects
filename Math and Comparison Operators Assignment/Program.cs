using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1Input = Console.ReadLine();
            decimal hourlyRate1;
            if (!decimal.TryParse(hourlyRate1Input, out hourlyRate1))
            {
                Console.WriteLine("Invalid input for hourly rate of Person 1.");
                return;
            }
            Console.WriteLine("Hours worked per week?");
            string hours1Input = Console.ReadLine();
            int hours1;
            if (!int.TryParse(hours1Input, out hours1))
            {
                Console.WriteLine("Invalid input for hours worked per week of Person 1.");
                return;
            }
            decimal salary1 = hourlyRate1 * hours1 * 52;

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2Input = Console.ReadLine();
            decimal hourlyRate2;
            if (!decimal.TryParse(hourlyRate2Input, out hourlyRate2))
            {
                Console.WriteLine("Invalid input for hourly rate of Person 2.");
                return;
            }
            Console.WriteLine("Hours worked per week?");
            string hours2Input = Console.ReadLine();
            int hours2;
            if (!int.TryParse(hours2Input, out hours2))
            {
                Console.WriteLine("Invalid input for hours worked per week of Person 2.");
                return;
            }
            decimal salary2 = hourlyRate2 * hours2 * 52;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isMore = salary1 > salary2;

            Console.WriteLine(isMore);

            Console.ReadLine();
        }
    }
}
