public class CyclingActivity : Activity
{
    private double _speed; // Speed in kilometers per hour

    public CyclingActivity(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (Minutes / 60.0) * _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}
