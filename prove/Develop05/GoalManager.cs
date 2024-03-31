// GoalManager.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();

    public void CreateGoal(string name, int value, GoalType type, int targetCount = 0)
    {
        Goal goal;
        switch (type)
        {
            case GoalType.Simple:
                goal = new SimpleGoal(name, value);
                break;
            case GoalType.Eternal:
                goal = new EternalGoal(name, value);
                break;
            case GoalType.Checklist:
                goal = new ChecklistGoal(name, value, targetCount);
                break;
            default:
                throw new ArgumentException("Invalid goal type");
        }
        goals.Add(goal);
    }

    public void RecordGoalCompletion(string name)
    {
        Goal goal = goals.FirstOrDefault(g => g.GetType().Name == name);
        if (goal != null)
        {
            goal.RecordCompletion();
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayGoal());
        }
    }
}

public enum GoalType
{
    Simple,
    Eternal,
    Checklist
}
