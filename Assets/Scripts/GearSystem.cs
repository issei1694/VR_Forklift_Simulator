using UnityEngine;

public class ForkliftGear : MonoBehaviour
{
    // Gear: 1 = Forward, 0 = Neutral, -1 = Reverse
    public int currentGear = 1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            currentGear = -1; // Reverse
        else if (Input.GetKeyDown(KeyCode.N))
            currentGear = 0;  // Neutral
        else if (Input.GetKeyDown(KeyCode.F))
            currentGear = 1;  // Forward
    }
}
