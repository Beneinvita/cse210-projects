using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void PerformActivity()
    {
        StartActivity();
        int interval = 5; // 5 seconds for breathing in/out

        for (int i = 0; i < _duration / interval; i++)
        {
            Console.Write("Breathe in...");
            Countdown(interval);
            Console.Write("\nBreathe out...");
            Countdown(interval);
            Console.WriteLine();
        }

        EndActivity();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($" {i}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
    }
}
