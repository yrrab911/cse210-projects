public class ReflectionActivity : Activity
{
    private static int _reflectionActivityCount;
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public override void StartActivity()
    {
        base.StartActivity();
        Random rnd = new Random();
        Console.WriteLine(_prompts[rnd.Next(_prompts.Length)]);
        int seconds = 0;
        while (seconds < _duration)
        {
            Console.WriteLine(_questions[rnd.Next(_questions.Length)]);
            PauseWithAnimation();
            seconds += 5;
        }
        EndActivity();
    }

    public override void EndActivity()
    {
        base.EndActivity();
        _reflectionActivityCount++;
    }

    public static int GetReflectionActivityCount()
    {
        return _reflectionActivityCount;
    }
}
