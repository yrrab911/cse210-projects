public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Show activity counts");
            Console.WriteLine("5. Quit");
            string choice = Console.ReadLine();

            Activity activity;
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    activity.StartActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    activity.StartActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    activity.StartActivity();
                    break;
                case "4":
                    Console.WriteLine($"Breathing activities completed: {BreathingActivity.GetBreathingActivityCount()}");
                    Console.WriteLine($"Reflection activities completed: {ReflectionActivity.GetReflectionActivityCount()}");
                    Console.WriteLine($"Listing activities completed: {ListingActivity.GetListingActivityCount()}");
                    Console.WriteLine($"Total activities completed: {Activity.GetTotalActivitiesCompleted()}");
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    continue;
            }
        }
    }
}
