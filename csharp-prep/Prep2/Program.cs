using System;

class Program
{
    static void Main(string[] args)
     {
        // this will ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        // this will determine the letter grade
        string letter = ""; 
        string sign = ""; // Variable for the sign (+/-)
        
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Step 3: Determine the sign
        int lastDigit = gradePercentage % 10;
        if (letter != "A" && letter != "F") // No A+ or F+ grades
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Step 4: Print the letter grade with sign
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Step 5: Check if the user passed
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! You can do better next time.");
        }
    }
}