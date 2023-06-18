using System;

namespace EmployeeComparison
{

    class Program
    {

        static void Main(string[] args)
        {
            // Creating two Employee objects
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };

            // Comparing the Employee objects using the overloaded "==" operator
            bool areEqual = employee1 == employee2;

            Console.WriteLine($"Are the Employee objects equal? {areEqual}");
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading the "==" operator to compare two Employee objects by their Id property
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (ReferenceEquals(employee1, employee2))
            {
                return true; // If both objects are the same instance, they are considered equal
            }

            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            {
                return false; // If either object is null, they are not considered equal
            }

            return employee1.Id == employee2.Id; // Compare the Id property of both objects
        }

        // Overloading the "!=" operator as well for completeness (opposite of "==")
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2); // Use the already overloaded "==" operator
        }
    }


}
