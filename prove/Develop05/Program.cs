class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("1. Create Goal\n2. Record Event\n3. Display Goals\n4. Save Goals\n5. Load Goals\n6. Quit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.CreateGoal();
                    break;
                case 2:
                    manager.RecordEvent();
                    break;
                case 3:
                    manager.DisplayGoals();
                    break;
                case 4:
                    manager.SaveGoals("goals.txt");
                    break;
                case 5:
                    manager.LoadGoals("goals.txt");
                    break;
                case 6:
                    return;
            }
        }
    }
}
