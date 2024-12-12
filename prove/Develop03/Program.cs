using System;

class Program
{
    static void Main(string[] args)
    {
        // Example scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, scriptureText);

        Console.Clear();
        Console.WriteLine(scripture);

        while (true)
        {
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(scripture);

            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program will now exit.");
                break;
            }
        }
    }
}
