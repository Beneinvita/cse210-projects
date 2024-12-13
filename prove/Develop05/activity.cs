using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nEnter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready to begin...");
        PauseWithSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nGreat job!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        PauseWithSpinner(3);
    }

    protected void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds * 10; i++)
        {
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b\b");
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b\b");
            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b\b");
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b\b");
        }
    }

    public abstract void PerformActivity();
}
