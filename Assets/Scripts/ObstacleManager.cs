using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] private GameObject obstacle = null;
    [SerializeField] private float spawnChance = 1000f;
    [SerializeField] private int chanceOfLowerObstacle = 4;
    [SerializeField] private bool debug = false;
    
    // Initialised as 0 so that an obstacle is spawned on start
    private float waitTime = 0f;

    private void Update()
    {
        if (waitTime <= Time.time)
        {
            // Have different size obstacles.
            float calculatedSpawnChance = spawnChance * (200 / (1 + Time.time * Time.time));

            if (Random.Range(0, calculatedSpawnChance) < 1f)
            {
                SpawnObstacle();

                // Wait between spawns
                waitTime = Time.time + (calculatedSpawnChance / 100f);

                if (debug)
                {
                    Debug.LogFormat("Waiting for: {0} seconds", calculatedSpawnChance / 100f);
                    Debug.LogFormat("New Wait Time: {0} seconds", waitTime);
                    Debug.Log(Time.time.ToString());
                }
            }
        }
    }

    private void SpawnObstacle()
    {
        if (debug) Debug.Log("Obstacle Spawned");
        GameObject go = Instantiate(obstacle);
        if (Random.Range(0, chanceOfLowerObstacle) < 1)
        {
            go.GetComponent<Obstacle>().isTopObstacle = false;
        }
    }
}
