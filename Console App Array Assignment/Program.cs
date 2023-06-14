using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a one-dimensional Array of strings
        string[] stringArray = { "London", "Berlin", "Madrid", "Tokyo", "Kyiv" };

        Console.WriteLine("Enter the index of the string you want to display (0-4):");
        int stringIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the index is within the range of the array
        if (stringIndex >= 0 && stringIndex < stringArray.Length)
        {
            // Display the string at the selected index
            Console.WriteLine("Selected string: " + stringArray[stringIndex]);
        }
        else
        {
            // Display an error message if the index is out of range
            Console.WriteLine("Invalid index. The array does not contain an element at the selected index.");
        }

        // Create a one-dimensional Array of integers
        int[] intArray = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Enter the index of the integer you want to display (0-4):");
        int intIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the index is within the range of the array
        if (intIndex >= 0 && intIndex < intArray.Length)
        {
            // Display the integer at the selected index
            Console.WriteLine("Selected integer: " + intArray[intIndex]);
        }
        else
        {
            // Display an error message if the index is out of range
            Console.WriteLine("Invalid index. The array does not contain an element at the selected index.");
        }

        // Create a list of strings
        List<string> stringList = new List<string> { "Mars", "Jupiter", "Earth", "Venus", "Mercury" };

        Console.WriteLine("Enter the index of the string you want to display (0-4):");
        int listIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the index is within the range of the list
        if (listIndex >= 0 && listIndex < stringList.Count)
        {
            // Display the string at the selected index
            Console.WriteLine("Selected string: " + stringList[listIndex]);
        }
        else
        {
            // Display an error message if the index is out of range
            Console.WriteLine("Invalid index. The list does not contain an element at the selected index.");
        }
    }
}