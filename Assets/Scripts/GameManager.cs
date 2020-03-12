using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject obstacleManager = null;
    [SerializeField] private Text scoreText = null;
    private static int score = 0;
    private float timeGameStarted = 0;
    private bool gameStarted = false;

    private void Update()
    {
        if (gameStarted) UpdateScore();
    }

    private void UpdateScore()
    {
        score = (int)Mathf.Floor(Time.fixedUnscaledTime - timeGameStarted);
        scoreText.text = "Score: " + score;
    }

    public void OnStartClick()
    {
        Instantiate(obstacleManager);
        gameStarted = true;
        timeGameStarted = Time.fixedUnscaledTime;
    }

    public static void GameEnded()
    {
        GameOver _ = new GameOver(score);
    }
}
