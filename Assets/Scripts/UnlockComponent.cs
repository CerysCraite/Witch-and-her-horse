using UnityEngine;

public class UnlockComponent : MonoBehaviour
{
    public void UnlockNewComponent(AlchemicalComponent newComponent)
    {
        bool unlocked = false;
        int lastElemIndex = 0;
        foreach (AlchemicalComponent i in Components.unlockedComponents)
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
            Components.unlockedComponents[lastElemIndex] = newComponent;
            Components.availableComponents.Add(Components.unlockedComponents[lastElemIndex].componentName);
        }

    }

    public void Test()
    {
        UnlockNewComponent(Components.alchemicalComponents[1]);
        Debug.Log(Components.alchemicalComponents[1].essenceMaterial);
    }
}
