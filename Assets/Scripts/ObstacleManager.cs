using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] private GameObject obstacle = null;
    [SerializeField] private float spawnChance = 1000f;
    [SerializeField] private int chanceOfLowerObstacle = 4;

    private void Start()
    {
        SpawnObstacle();
    }

    private void Update()
    {
        // Have different size obstacles.
        float calculatedSpawnChance = spawnChance * (200 / (1 + Time.time * Time.time));
        Debug.Log(Mathf.Floor(calculatedSpawnChance));
        if (Random.Range(0, calculatedSpawnChance) < 1f)
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
