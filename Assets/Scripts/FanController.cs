using UnityEngine;

public class FanController : MonoBehaviour
{
    [SerializeField] private Rigidbody ball = null;
    [SerializeField] private float force = 5f;
    private float currSlider = 0f;

    private void Update()
    {
        // Change this to a slider?
        if (Input.GetKey(KeyCode.Space))
        {
            ball.velocity += Vector3.up * force * Time.deltaTime;
        }
        else
        {
            ball.velocity += Vector3.up * force * currSlider * Time.deltaTime;
        }
    }

    public void SliderChanged(float sliderValue)
    {
        currSlider = sliderValue;
    }
}
