using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nEnter your choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.PerformActivity();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.PerformActivity();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.PerformActivity();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please try again.");
                Thread.Sleep(2000);
            }
        }
    }
}
