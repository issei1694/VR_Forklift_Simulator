using UnityEngine;

public class SteeringWheelController : MonoBehaviour
{
    public Transform steeringWheel;
    public float maxRotation = 45f;

    void Update()
    {
        float turnInput = Input.GetAxis("Horizontal");
        float rotation = turnInput * maxRotation;
        steeringWheel.localRotation = Quaternion.Euler(0, 0, -rotation);
    }
}
