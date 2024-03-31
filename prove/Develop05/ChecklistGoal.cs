// ChecklistGoal.cs
using System;

public class ChecklistGoal : Goal
{
    private int targetCount;
    private int completedCount;

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        this.targetCount = targetCount;
        this.completedCount = 0;
    }

    public override void RecordCompletion()
    {
        ScoreManager.AddPoints(value);
        completedCount++;
        if (completedCount == targetCount)
        {
            ScoreManager.AddPoints(500);
        }
    }

    public override string DisplayGoal()
    {
        return $"{name}: Completed {completedCount}/{targetCount} times ({value} points each)";
    }
}
