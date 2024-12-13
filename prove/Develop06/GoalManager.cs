using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.Name == goalName)
            {
                goal.RecordEvent();
                _totalPoints += goal.Points;
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{goal.GetStatus()} {goal.Name}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Points: {_totalPoints}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalPoints);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetType().Name);
                writer.WriteLine(goal.Name);
                writer.WriteLine(goal.Points);

                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine(checklistGoal.GetStatus());
                }
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            _totalPoints = int.Parse(reader.ReadLine());
            while (!reader.EndOfStream)
            {
                string goalType = reader.ReadLine();
                string name = reader.ReadLine();
                int points = int.Parse(reader.ReadLine());

                if (goalType == nameof(SimpleGoal))
                {
                    _goals.Add(new SimpleGoal(name, points));
                }
                else if (goalType == nameof(EternalGoal))
                {
                    _goals.Add(new EternalGoal(name, points));
                }
                else if (goalType == nameof(ChecklistGoal))
                {
                    _goals.Add(new ChecklistGoal(name, points, 0, 0));
                }
            }
        }
    }
}
