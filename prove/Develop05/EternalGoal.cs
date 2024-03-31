// EternalGoal.cs
using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value) { }

    public override void RecordCompletion()
    {
        ScoreManager.AddPoints(value);
    }
}
