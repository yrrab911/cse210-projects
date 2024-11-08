public class Activity
{
    protected int _duration;
    protected string _name;
    protected string _description;
    private static int _totalActivitiesCompleted;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public virtual void StartActivity()
    {
        Console.WriteLine($"{_name}: {_description}");
        Console.WriteLine("Please enter the duration in seconds:");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation();
    }

    public virtual void EndActivity()
    {
        Console.WriteLine("Good job! You’ve completed the activity.");
        Console.WriteLine($"Activity: {_name}, Duration: {_duration} seconds");
        PauseWithAnimation();
        _totalActivitiesCompleted++;
    }

    public static int GetTotalActivitiesCompleted()
    {
        return _totalActivitiesCompleted;
    }

    protected void PauseWithAnimation()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write(". ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
