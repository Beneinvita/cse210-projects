using System;

public abstract class Goal
{
    private string _name;
    private int _points;

    protected Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }

    public string Name => _name;
    public int Points => _points;

    public abstract void RecordEvent();
    public abstract string GetStatus();
    public abstract bool IsComplete();
}
