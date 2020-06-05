using System;
using System.Collections.Generic;
using System.Linq;

public class Bank
{

    public int CashOnHand
    {
        get
        {
            Random rand = new Random();
            return rand.Next(50000, 1_000_001);
        }
    }
    public int AlarmScore
    {
        get
        {
            Random rand = new Random();
            return rand.Next(0, 101);
        }
    }
    public int VaultScore
    {
        get
        {
            Random rand = new Random();
            return rand.Next(0, 101);
        }
    }
    public int SecurityGuardScore
    {
        get
        {
            Random rand = new Random();
            return rand.Next(0, 101);
        }
    }
    public bool IsSecure
    {
        get
        {
            if (AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardScore <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }

    public void bankRecon()
    {
        Dictionary<string, int> scoreList = new Dictionary<string, int>();
        scoreList.Add("Alarm", AlarmScore);
        scoreList.Add("Vault", VaultScore);
        scoreList.Add("Security", SecurityGuardScore);

        List<string> sortedScores = scoreList.OrderBy(score => score.Value).Select(k => k.Key).ToList();

        string lowestScore = sortedScores[0];
        string highestScore = sortedScores[2];

        Console.WriteLine($"Most Secure: {highestScore}");
        Console.WriteLine($"Least Secure: {lowestScore}");

    }

}