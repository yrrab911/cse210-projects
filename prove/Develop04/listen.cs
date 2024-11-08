public class ListingActivity : Activity
{
    private static int _listingActivityCount;
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life.")
    {
    }

    public override void StartActivity()
    {
        base.StartActivity();
        Random rnd = new Random();
        Console.WriteLine("Think and start listing items when ready...");

        int count = 0;
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine(_prompts[rnd.Next(_prompts.Length)]);
            Console.WriteLine("Enter an item:");
            string item = Console.ReadLine();
            count++;
        }
        
        Console.WriteLine($"You listed {count} items.");
        EndActivity();
    }

    public override void EndActivity()
    {
        base.EndActivity();
        _listingActivityCount++;
    }

    public static int GetListingActivityCount()
    {
        return _listingActivityCount;
    }
}
