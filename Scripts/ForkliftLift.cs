using UnityEngine;

public class ForkliftLift : MonoBehaviour
{
    public Transform forks;
    public float liftSpeed = 2f;
    public float maxHeight = 5f;
    public float minHeight = 1f;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            float newY = Mathf.Min(forks.localPosition.y + liftSpeed * Time.deltaTime, maxHeight);
            forks.localPosition = new Vector3(forks.localPosition.x, newY, forks.localPosition.z);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            float newY = Mathf.Max(forks.localPosition.y - liftSpeed * Time.deltaTime, minHeight);
            forks.localPosition = new Vector3(forks.localPosition.x, newY, forks.localPosition.z);
        }
    }
}
