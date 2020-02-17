using UnityEngine;

public class FanController : MonoBehaviour
{
    [SerializeField] private Rigidbody ball = null;
    [SerializeField] private float force = 5f;

    private void Update()
    {
        // Change this to a slider?
        if (Input.GetKey(KeyCode.Space))
        {
            ball.velocity += Vector3.up * force * Time.deltaTime;
        }
    }
}
