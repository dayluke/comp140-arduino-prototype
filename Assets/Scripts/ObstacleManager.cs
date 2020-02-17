using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] private GameObject obstacle = null;
    [SerializeField] private int spawnChance = 5;
    [SerializeField] private int chanceOfLowerObstacle = 4;

    private void Start()
    {
        SpawnObstacle();
    }

    private void Update()
    {
        // Increasing chance of obstacle spawning over time
        // Have different size obstacles.
        if (Random.Range(0, spawnChance) < 1)
        {
            SpawnObstacle();
        }
    }

    private void SpawnObstacle()
    {
        GameObject go = Instantiate(obstacle);
        if (Random.Range(0, chanceOfLowerObstacle) < 1)
        {
            go.GetComponent<Obstacle>().isTopObstacle = false;
        }
    }
}
