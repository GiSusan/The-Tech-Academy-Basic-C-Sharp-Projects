using System;

namespace ConsoleApp
{
    // Step 1: Create an interface called IQuittable with a Quit() method
    public interface IQuittable
    {
        void Quit();
    }

    // Step 2: Employee class inherits from IQuittable interface and implements Quit() method
    public class Employee : IQuittable
    {
        public string Name { get; set; }

        // Implementing the Quit() method form the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("Employee quits the job."); // Display a message when the Quit() method is called
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Step 3: Using polymorphism to create an object of type IQuittable and call Quit() method
            IQuittable quittableEmployee = new Employee();
            quittableEmployee.Quit();

            // Output: "Employee quits the job."
        }
    }
}
