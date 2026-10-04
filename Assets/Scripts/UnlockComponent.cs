using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UnlockComponent : MonoBehaviour
{
    public Components components;
    Clock clock;
    Transform earth;

    AlchemicalComponent[] lockedComponents;

    List<Sprite> lockedIcons = new List<Sprite> { null };

    bool searching = false;

    Sprite currentIcon;
    GameObject iconDisplay;
    GameObject foundItem;
    GameObject text;


    [SerializeField] float searchDuration = 5;
    [SerializeField] float speedIncrease = 0.4f;
    float currDuration;

    private void Start()
    {
        components = FindAnyObjectByType<Components>();
        clock = FindAnyObjectByType<Clock>();
        earth = GameObject.Find("Earth").transform;
        iconDisplay = transform.GetChild(1).gameObject;
        iconDisplay.SetActive(false);
        text = transform.GetChild(0).gameObject;
        foundItem = transform.GetChild(2).gameObject;

        lockedComponents = components.alchemicalComponents;

        foreach (AlchemicalComponent i in lockedComponents)
        {
            lockedIcons.Add(i.componentIcon);
        }
    }

    private void FixedUpdate()
    {
        if (currDuration < searchDuration && searching)
        {
            earth.Rotate(0, 0, speedIncrease);
            currDuration += Time.deltaTime;

            if(currDuration % 0.2 < 0.1)
            {            
                currentIcon = lockedIcons[Random.Range(0, lockedIcons.Count)];
                iconDisplay.GetComponent<Image>().sprite = currentIcon;
            }
        }
        else if (searching)
        {
            searching = false;
            clock.clockSpeed -= speedIncrease;
            currDuration = 0;
            iconDisplay.SetActive(false);
            foundItem.SetActive(true);           
        }
    }


    public void UnlockNewComponent(int newComponentIndex)
    {
        AlchemicalComponent newComponent = lockedComponents[newComponentIndex];

        if (newComponent == null)
            UnlockNewComponent(Random.Range(0, lockedComponents.Length));

        else
        {
            int lastElemIndex = 0;
            foreach (AlchemicalComponent i in components.unlockedComponents)
            {
                if (i != null)
                    lastElemIndex++;
            }

            Debug.Log(lastElemIndex + " unlocking " + newComponent.componentName);

            lockedIcons.Remove(newComponent.componentIcon);
            foundItem.GetComponent<Image>().sprite = newComponent.componentIcon;

            components.unlockedComponents[lastElemIndex] = newComponent;
            lockedComponents[newComponentIndex] = null;

            Components.availableComponents.Add(newComponent.componentName);
        }
    }

    

    public void StartSearch()
    {
        UnlockNewComponent(Random.Range(0, lockedComponents.Length));
        searching = true;
        iconDisplay.SetActive(true);
        iconDisplay.GetComponent<Image>().color = Color.black;
        text.SetActive(false);
        foundItem.SetActive(false);
        clock.clockSpeed += speedIncrease;
    }
}
