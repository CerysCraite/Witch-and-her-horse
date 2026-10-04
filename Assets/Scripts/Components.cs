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
    public GameObject[] headVariants;
    public GameObject[] bodyVariants;
    public GameObject[] tailVariants;
    public GameObject[] markVariants;

    public AlchemicalComponent[] unlockedComponents = new AlchemicalComponent[13];
    public static List<string> availableComponents = new List<string> {null};

    private void Start()
    {
        Debug.Log("fuck");
        alchemicalComponents = new AlchemicalComponent[]{
                                  new AlchemicalComponent("jackolantern",
                                                          0,
                                                          null, bodyVariants[0], tailVariants[0],
                                                          headVariants[0], null, null),

                                  new AlchemicalComponent("chamomile tea",
                                                          1,
                                                          headVariants[1], bodyVariants[1], null,
                                                          null, null, tailVariants[1]),

                                  new AlchemicalComponent("marshmallow",
                                                          2,
                                                          headVariants[2], bodyVariants[2], null,
                                                          null, null, tailVariants[2]),

                                  new AlchemicalComponent("apple",
                                                          3,
                                                          headVariants[3], bodyVariants[3], null,
                                                          null, null, tailVariants[3]),

                                  new AlchemicalComponent("pumpkin latte",
                                                          4,
                                                          headVariants[4], bodyVariants[4], tailVariants[4],
                                                          null, markVariants[0], null),

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
                                                          null, bodyVariants[5], tailVariants[5],
                                                          headVariants[5], null, null),

                                  new AlchemicalComponent("honeycomb",
                                                          9,
                                                          null, null, null,
                                                          null, null, null),

                                  new AlchemicalComponent("cinnamon",
                                                          10,
                                                          headVariants[6], bodyVariants[6], null,
                                                          null, null, tailVariants[6]),

                                  new AlchemicalComponent("lime",
                                                          11,
                                                          headVariants[7], bodyVariants[7], null,
                                                          null, null, tailVariants[7]),
        };

        DontDestroyOnLoad(this);
    }

}
