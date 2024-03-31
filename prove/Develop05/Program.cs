using System;

public class Program
{
    public static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Goal Completion");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goalManager);
                    break;
                case "2":
                    RecordGoalCompletion(goalManager);
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    Console.WriteLine($"Total Score: {ScoreManager.GetScore()}");
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void CreateGoal(GoalManager goalManager)
    {
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter points for completion:");
        int value = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Select goal type (1. Simple, 2. Eternal, 3. Checklist):");
        int typeChoice = Convert.ToInt32(Console.ReadLine());

        GoalType type = (GoalType)(typeChoice - 1);

        if (type == GoalType.Checklist)
        {
            Console.WriteLine("Enter target count:");
            int targetCount = Convert.ToInt32(Console.ReadLine());
            goalManager.CreateGoal(name, value, type, targetCount);
        }
        else
        {
            goalManager.CreateGoal(name, value, type);
        }
    }

    private static void RecordGoalCompletion(GoalManager goalManager)
    {
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();
        goalManager.RecordGoalCompletion(name);
    }
}
