using UnityEngine;

public class Clock : MonoBehaviour
{

    public float clockSpeed = 0.1f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0,0,-clockSpeed);
    }
}
