using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChooseComponent : MonoBehaviour
{
    CombinationRitual ritualScript;
    TMP_Dropdown dropdownMenu;
    public Components components;
    Image selectedIcon;

    private void Start()
    {
        components = FindAnyObjectByType<Components>();
        ritualScript = GameObject.FindAnyObjectByType<CombinationRitual>();
        dropdownMenu = transform.GetComponent<TMP_Dropdown>();
        dropdownMenu.ClearOptions();
        dropdownMenu.AddOptions(Components.availableComponents);
        selectedIcon = transform.GetChild(0).GetComponent<Image>();
        selectedIcon.enabled = false;
    }

    public void ChooseEssence()
    {
        if (dropdownMenu.value >= 1)
        {
            ritualScript.essence = components.unlockedComponents[dropdownMenu.value - 1];
            Debug.Log(ritualScript.essence.componentName + " as essence");
            selectedIcon.enabled = true;
            selectedIcon.sprite = ritualScript.essence.componentIcon;
        }
        else
        {
            ritualScript.essence = null;
            selectedIcon.enabled = false;
        }
            
        
    }

    public void ChooseReagent()
    {
        if (dropdownMenu.value >= 1)
        {
            ritualScript.reagent = components.unlockedComponents[dropdownMenu.value - 1];
            Debug.Log(ritualScript.reagent.componentName + " as reagent");
            selectedIcon.enabled = true;
            selectedIcon.sprite = ritualScript.reagent.componentIcon;
        }
            
        else
        {
            ritualScript.reagent = null;
            selectedIcon.enabled = false;
        }
            
        
    }

    public void ChooseCatalyst()
    {
        if (dropdownMenu.value >= 1)
        {
            ritualScript.catalyst = components.unlockedComponents[dropdownMenu.value - 1];
            Debug.Log(ritualScript.catalyst.componentName + " as catalyst");
            selectedIcon.enabled = true;
            selectedIcon.sprite = ritualScript.catalyst.componentIcon;
        }
        else
        {
            ritualScript.catalyst = null;
            selectedIcon.enabled = false;
        }
            
    }
}
