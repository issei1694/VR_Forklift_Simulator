using UnityEngine;

public class EngineController : MonoBehaviour
{
    public bool engineStarted = false;

    public void StartEngine()
    {
        engineStarted = true;
        Debug.Log("🚜 Engine started!");
        // Optional: Add sound or animation
    }
}
