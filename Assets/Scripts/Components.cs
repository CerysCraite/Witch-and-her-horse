using System.Collections.Generic;
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
    public AlchemicalComponent[] alchemicalComponents = new AlchemicalComponent[13];
    public GameObject[] horseVariants; 
     
    public AlchemicalComponent[] unlockedComponents = new AlchemicalComponent[13];
    public static List<string> availableComponents = new List<string> {null};

    private void Start()
    {
        Debug.Log("fuck");
        alchemicalComponents = new AlchemicalComponent[]{
                                  new AlchemicalComponent("jackolantern",
                                                          0,
                                                          null, horseVariants[1], horseVariants[2],
                                                          horseVariants[0], null, null),

                                  new AlchemicalComponent("chamomile tea",
                                                          1,
                                                          horseVariants[3], horseVariants[4], null,
                                                          null, null, horseVariants[5]),

                                  new AlchemicalComponent("marshmallow",
                                                          2,
                                                          horseVariants[6], horseVariants[7], null,
                                                          null, null, horseVariants[8]),

                                  new AlchemicalComponent("apple",
                                                          3,
                                                          horseVariants[9], horseVariants[10], null,
                                                          null, null, horseVariants[11]),

                                  new AlchemicalComponent("pumpkin latte",
                                                          4,
                                                          horseVariants[12], horseVariants[13], horseVariants[14],
                                                          null, horseVariants[15], null),

                                  new AlchemicalComponent("ghost cookies",
                                                          5,
                                                          null, null, null,
                                                          null, null, null),

                                  new AlchemicalComponent("scented candles",
                                                          6,
                                                          null, null, null,
                                                          null, null, null),

                                  new AlchemicalComponent("mushrooms",
                                                          7,
                                                          null, null, null,
                                                          null, null, null),

                                  new AlchemicalComponent("flaming skull",
                                                          8,
                                                          null, horseVariants[17], horseVariants[18],
                                                          horseVariants[16], null, null),

                                  new AlchemicalComponent("honeycomb",
                                                          9,
                                                          null, null, null,
                                                          null, null, null),

                                  new AlchemicalComponent("cinnamon",
                                                          10,
                                                          horseVariants[19], horseVariants[20], null,
                                                          null, null, horseVariants[21]),
        };

        DontDestroyOnLoad(this);
    }

}
