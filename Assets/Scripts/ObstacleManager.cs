using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] private GameObject obstacle = null;
    [SerializeField] private int spawnChance = 5;

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
        Instantiate(obstacle);
    }
}
