using UnityEngine;

public class HorseBobbing : MonoBehaviour
{
    float bobInterval = 1, bobDistance = 0.1f;
    bool up;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time % bobInterval > 0.5 && up)
        {
            transform.Translate(0, bobDistance, 0);
            up = false;
        }            
        else if(Time.time % bobInterval < 0.5 && !up)
        {
            transform.Translate(0, -bobDistance, 0);
            up = true;
        }
    }
}
