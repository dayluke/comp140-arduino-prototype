using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private Vector3 endPoint = Vector3.zero;
    [SerializeField] private float speed = 5f;

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
