using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int points = int.Parse(Console.ReadLine());
                    goalManager.AddGoal(new SimpleGoal(name, points));
                    break;
                case "2":
                    Console.Write("Enter goal name: ");
                    string goalName = Console.ReadLine();
                    goalManager.RecordEvent(goalName);
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    goalManager.DisplayScore();
                    break;
                case "5":
                    goalManager.SaveGoals("goals.txt");
                    break;
                case "6":
                    goalManager.LoadGoals("goals.txt");
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
