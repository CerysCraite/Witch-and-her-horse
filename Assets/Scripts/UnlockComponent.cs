using UnityEngine;
using UnityEngine.UI;

public class UnlockComponent : MonoBehaviour
{
    public Components components;
    Clock clock;
    Transform earth;
    bool searching = false;

    [SerializeField] float searchDuration = 5;
    [SerializeField] float speedIncrease = 0.4f;
    float currDuration;

    private void Start()
    {
        components = FindAnyObjectByType<Components>();
        clock = FindAnyObjectByType<Clock>();
        earth = GameObject.Find("Earth").transform;
    }

    private void FixedUpdate()
    {
        if (currDuration < searchDuration && searching)
        {
            earth.Rotate(0, 0, speedIncrease);
            currDuration += Time.deltaTime;
        }
        else if (searching)
        {
            searching = false;
            clock.clockSpeed -= speedIncrease;
            currDuration = 0;
            transform.localPosition = Vector2.zero;
        }
    }


    public void UnlockNewComponent(AlchemicalComponent newComponent)
    {
        bool unlocked = false;
        int lastElemIndex = 0;
        foreach (AlchemicalComponent i in components.unlockedComponents)
        {
            if (i != null)
                lastElemIndex++;
            if (newComponent == i)
            {
                unlocked = true;
                Debug.Log("Component already unlocked");
            }               
        }

        if (unlocked == false)
        {
            Debug.Log(lastElemIndex + " unlocking " + newComponent.componentName);
            components.unlockedComponents[lastElemIndex] = newComponent;
            Debug.Log(components.unlockedComponents[lastElemIndex]);
            Components.availableComponents.Add(components.unlockedComponents[lastElemIndex].componentName);
        }

    }

    

    public void StartSearch()
    {
        UnlockNewComponent(components.alchemicalComponents[Random.Range(0, components.alchemicalComponents.Length)]);
        searching = true;
        clock.clockSpeed += speedIncrease;
        transform.Translate(0, 2000, 0);
    }
}
