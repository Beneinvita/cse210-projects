public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        if (_currentCount == _targetCount)
        {
            Console.WriteLine($"Congratulations! You completed the goal '{Name}' and earned {Points + _bonusPoints} points!");
        }
        else
        {
            Console.WriteLine($"You recorded progress for the goal '{Name}' and earned {Points} points!");
        }
    }

    public override string GetStatus()
    {
        return _currentCount >= _targetCount ? "[X]" : $"[ ] Completed {_currentCount}/{_targetCount}";
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }
}
