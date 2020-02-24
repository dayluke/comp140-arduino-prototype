using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private Vector3 endPoint = Vector3.zero;
    [SerializeField] private float speed = 5f;
    [SerializeField] public bool isTopObstacle = true;
    [SerializeField] private float minHeight = 0.5f;
    [SerializeField] private float maxHeight = 5f;
    // [SerializeField] private float spaceBetween; // <- Spawn two obstacles every time??

    private void Start()
    {
        if (!isTopObstacle)
        {
            transform.position -= (Vector3.up * (transform.position.y - 0.5f));
        }
        RandomiseHeight();
    }

    private void RandomiseHeight()
    {
        float height = Random.Range(minHeight, maxHeight);
        transform.localScale += Vector3.up * height;
        transform.position += isTopObstacle ? -Vector3.up * (height / 2) : Vector3.up * (height / 2);
    }

    private void Update()
    {
        MoveObstacle();
        CheckEndPointReached();
    }

    private void MoveObstacle()
    {
        // Make speed slowly increase over time.
        transform.position += -Vector3.right * speed * Time.deltaTime;
    }

    private void CheckEndPointReached()
    {
        if (transform.position.x <= endPoint.x)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Debug.Log("Player lost!");
        }
    }
}
