using UnityEngine;

public class SliderMapper : MonoBehaviour
{
    public FanController fan;
    public int maxValue;
    public int minValue;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value">a float value between 0 and 1</param>
    public void OnValueChanged(float value)
    {
        float newValue = Remap(value, 0, 1, minValue, maxValue);
        fan.SliderChanged(newValue);
    }

    private float Remap(float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }

}
