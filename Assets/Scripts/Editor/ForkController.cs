using UnityEngine;

public class ForkController : MonoBehaviour
{
    [Header("Forklift Fork Settings")]
    public Transform fork;        // Reference to the fork object
    public float minHeight = 0.5f; // Minimum Y position
    public float maxHeight = 2.0f; // Maximum Y position

    // Set height via normalized value (0 to 1), e.g. from a slider
    public void SetForkHeight(float normalizedValue)
    {
        if (fork == null) return;

        float newY = Mathf.Lerp(minHeight, maxHeight, normalizedValue);
        Vector3 currentLocalPos = fork.localPosition;
        fork.localPosition = new Vector3(currentLocalPos.x, newY, currentLocalPos.z);

        Debug.Log($"Fork Height Set: {newY}");
    }

    // Optional: Manually lift or lower fork in steps
    public void MoveFork(float delta)
    {
        if (fork == null) return;

        float newY = Mathf.Clamp(fork.localPosition.y + delta, minHeight, maxHeight);
        fork.localPosition = new Vector3(fork.localPosition.x, newY, fork.localPosition.z);

        Debug.Log($"Fork Height Changed by delta: {delta}");
    }
}
