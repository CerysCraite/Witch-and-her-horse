using UnityEngine;

public class UnlockComponent : MonoBehaviour
{
    public Components components;

    private void Start()
    {
        components = FindAnyObjectByType<Components>();
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

    

    public void Test()
    {
        UnlockNewComponent(components.alchemicalComponents[Random.Range(0, components.alchemicalComponents.Length)]);
    }
}
