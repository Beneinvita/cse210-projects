using System;

class Program
{
    static void Main(string[] args)
    {// this will  Prompt the user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // this will Prompt the user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // this is to Display the formatted output
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}