using System; // Importing System namespace for input/output operations
using System.Collections.Generic; // Importing namespace for working with lists

class Program
{
    static void Main(string[] args)
    {
        // Initialize an empty list to store the numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userInput;
        do
        {
            // Prompt the user to enter a number
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            // Add the number to the list if it is not 0
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        } while (userInput != 0); // Loop continues until the user enters 0

        // Core Requirement 1: Compute and display the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Core Requirement 2: Compute and display the average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Core Requirement 3: Find and display the maximum number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge 1: Find and display the smallest positive number
        int smallestPositive = int.MaxValue; // Start with the largest possible value
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        if (smallestPositive == int.MaxValue)
        {
            Console.WriteLine("No positive numbers were entered.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Stretch Challenge 2: Sort and display the list in ascending order
        numbers.Sort(); // Using the Sort method to sort the list
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
