using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            string weightInput = Console.ReadLine();
            int weight = int.Parse(weightInput);

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please enter the package width:");
            string widthInput = Console.ReadLine();
            int width = int.Parse(widthInput);

            Console.WriteLine("Please enter the package height:");
            string heightInput = Console.ReadLine();
            int height = int.Parse(heightInput);

            Console.WriteLine("Please enter the package length:");
            string lengthInput = Console.ReadLine();
            int length = int.Parse(lengthInput);

            int dimensions = width * height * length;
            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            decimal quote = (decimal)(dimensions * weight) / 100;

            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!");

            Console.ReadLine();
        }
    }
}
