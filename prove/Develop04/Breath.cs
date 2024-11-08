public class BreathingActivity : Activity
{
    private static int _breathingActivityCount;

    public BreathingActivity() : base("Breathing", "This activity will help you relax by focusing on your breathing.")
    {
    }

    public override void StartActivity()
    {
        base.StartActivity();
        int seconds = 0;
        while (seconds < _duration)
        {
            Console.WriteLine("Breathe in...");
            Countdown(3);
            Console.WriteLine("Breathe out...");
            Countdown(3);
            seconds += 6;
        }
        EndActivity();
    }

    public override void EndActivity()
    {
        base.EndActivity();
        _breathingActivityCount++;
    }

    public static int GetBreathingActivityCount()
    {
        return _breathingActivityCount;
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
