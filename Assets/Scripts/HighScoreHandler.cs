using UnityEngine;

public class HighScoreHandler
{
    private const string playerPrefString = "HighScore";

    public static int GetHighScore()
    {
        int currHighScore = PlayerPrefs.GetInt(playerPrefString, 0);
        Debug.Log("CURRENT HIGH SCORE: " + currHighScore);
        return currHighScore;
    }

    public static void SetHighScore(int score)
    {
        PlayerPrefs.SetInt(playerPrefString, score);
        Debug.Log("NEW HIGH SCORE: " + score);
    }
}
