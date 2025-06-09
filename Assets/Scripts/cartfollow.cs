using UnityEngine;

public class XRFollowForklift : MonoBehaviour
{
    public Transform forklift; // Assign your forklift GameObject here
    public Vector3 offset = new Vector3(0, 0, 0); // Optional: adjust this if XR Origin should stay behind/inside forklift

    void LateUpdate()
    {
        if (forklift == null) return;

        // Move XR Origin to follow forklift
        transform.position = forklift.position + offset;
        transform.rotation = forklift.rotation;
    }
}
