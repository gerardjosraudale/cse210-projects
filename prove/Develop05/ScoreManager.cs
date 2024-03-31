// ScoreManager.cs
using System;

public static class ScoreManager
{
    private static int score = 0;

    public static void AddPoints(int points)
    {
        score += points;
    }

    public static int GetScore()
    {
        return score;
    }
}
