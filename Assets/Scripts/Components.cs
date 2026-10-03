using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class AlchemicalComponent
{
    public string componentName;
    public int essenceMaterial;
    public GameObject reagentHead;
    public GameObject reagentBody;
    public GameObject reagentTail;
    public GameObject catalystHead;
    public GameObject catalystMark;
    public GameObject catalystTail;

    public AlchemicalComponent(string name, int essenceColour, GameObject reagentAddHead, GameObject reagentAddBody, GameObject reagentAddTail, GameObject catalystAddHead, GameObject catalystAddMark, GameObject catalystAddTail)
    {
        componentName = name;
        essenceMaterial = essenceColour;
        reagentHead = reagentAddHead;
        reagentBody = reagentAddBody;
        reagentTail = reagentAddTail;
        catalystHead = catalystAddHead;
        catalystMark = catalystAddMark;
        catalystTail = catalystAddTail;
    }

}

public class Components : MonoBehaviour
{
    public static AlchemicalComponent[] alchemicalComponents = new AlchemicalComponent[]
        {new AlchemicalComponent("jackolantern",
                                  0,
                                  null, null, null,
                                  null, null, null),

        new AlchemicalComponent("acorn",
                                  1,
                                  null, null, null,
                                  null, null, null),
        new AlchemicalComponent("apple",
                                  1,
                                  null, null, null,
                                  null, null, null),
        };

    public static AlchemicalComponent[] unlockedComponents = new AlchemicalComponent[alchemicalComponents.Length];
    public static List<string> availableComponents = new List<string> {null};
}
