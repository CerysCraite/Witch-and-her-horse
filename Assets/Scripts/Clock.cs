using UnityEngine;

public class Clock : MonoBehaviour
{

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0,0,-0.1f);
    }
}
