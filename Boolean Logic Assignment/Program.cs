using System;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Program");

            // Ask applicant's age
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask if applicant has had a DUI
            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            // Ask number of speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Check qualification based on the rules
            bool qualified = age > 15 && !hasDUI && speedingTickets <= 3;

            // Print the result
            Console.WriteLine("Qualified? " + qualified);

            Console.ReadLine();
        }
    }
}

