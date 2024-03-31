// Goal.cs
using System;

public abstract class Goal
{
    protected string name;
    protected int value;

    public Goal(string name, int value)
    {
        this.name = name;
        this.value = value;
    }

    public abstract void RecordCompletion();

    public virtual string DisplayGoal()
    {
        return $"{name}: {value} points";
    }
}
