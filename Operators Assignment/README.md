# Operators Assignment Submission

This console application demonstrates the comparison of `Employee` objects based on their `Id` property.

## Employee Class

The `Employee` class represents an employee and has the following properties:

- `Id`: The unique identifier of the employee.
- `FirstName`: The first name of the employee.
- `LastName`: The last name of the employee.

The `Employee` class also overloads the `==` operator to compare two `Employee` objects by their `Id` property.

## Usage

1. Clone or download the repository.
2. Open the solution in your preferred development environment (e.g., Visual Studio).
3. Build the solution to restore dependencies and compile the code.
4. Run the application.
5. The application will create two `Employee` objects with different first names but the same `Id` value.
6. The overloaded `==` operator is used to compare the equality of the two `Employee` objects.
7. The result is displayed in the console, indicating whether the `Employee` objects are equal or not.

## Example

In the code provided, the `Employee` class and the `Program` class are defined. The `Program` class contains the entry point of the application, which executes the comparison of `Employee` objects.

```csharp
// Employee class definition

public class Employee
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overloaded "==" operator for comparison
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        // Comparison logic
    }

    // Overloaded "!=" operator as the opposite of "=="
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        // Inverse comparison using "=="
    }
}

// Program class with the entry point

class Program
{
    static void Main(string[] args)
    {
        // Code to compare Employee objects
    }
}
