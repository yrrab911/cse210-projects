public class Cycling : Activity
{
    private double speed; // in mph

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed / 60) * GetMinutes();

    public override double GetSpeed() => speed;

    public override double GetPace() => 60 / speed;
}
