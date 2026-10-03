using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ChooseComponent : MonoBehaviour
{
    CombinationRitual ritualScript;
    TMP_Dropdown dropdownMenu;
    public Components components;

    private void Start()
    {
        components = FindAnyObjectByType<Components>();
        ritualScript = GameObject.FindAnyObjectByType<CombinationRitual>();
        dropdownMenu = transform.GetComponent<TMP_Dropdown>();
        dropdownMenu.ClearOptions();
        dropdownMenu.AddOptions(Components.availableComponents);
    }

    public void ChooseEssence()
    {
        if (dropdownMenu.value >= 1)
        {
            ritualScript.essence = components.unlockedComponents[dropdownMenu.value - 1];
            Debug.Log(ritualScript.essence.componentName + " as essence");
        }
        else
            ritualScript.essence = null;
        
    }

    public void ChooseReagent()
    {
        if (dropdownMenu.value >= 1)
        {
            ritualScript.reagent = components.unlockedComponents[dropdownMenu.value - 1];
            Debug.Log(ritualScript.reagent.componentName + " as reagent");
        }
            
        else
            ritualScript.reagent = null;
        
    }

    public void ChooseCatalyst()
    {
        if (dropdownMenu.value >= 1)
        {
            ritualScript.catalyst = components.unlockedComponents[dropdownMenu.value - 1];
            Debug.Log(ritualScript.catalyst.componentName + " as catalyst");
        }
        else
            ritualScript.catalyst = null;
    }
}
