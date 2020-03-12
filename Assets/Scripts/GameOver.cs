using UnityEngine;

public class GameOver
{
    public GameOver(int playersScore)
    {
        GameObject.Find("Game Over Text").transform.position -= Vector3.forward * 8.3f;
        Time.timeScale = 0f;

        if (playersScore > HighScoreHandler.GetHighScore())
        {
            HighScoreHandler.SetHighScore(playersScore);
        }
    }
}