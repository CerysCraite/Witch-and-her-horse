using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlchemicalComponent
{
    public string componentName;
    public int essenceMaterial;
    public string bodyFrame;
    public GameObject reagentHead;
    public GameObject reagentBody;
    public GameObject reagentTail;
    public GameObject catalystHead;
    public GameObject catalystMark;
    public GameObject catalystTail;

    public AlchemicalComponent(string name, int essenceColour, string horseFrame, GameObject reagentAddHead, GameObject reagentAddBody, GameObject reagentAddTail, GameObject catalystAddHead, GameObject catalystAddMark, GameObject catalystAddTail)
    {
        componentName = name;
        essenceMaterial = essenceColour;
        bodyFrame = horseFrame;
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
                                                          0, "horse",
                                                          null, bodyVariants[0], tailVariants[0],
                                                          headVariants[0], null, null),

                                  new AlchemicalComponent("chamomile tea",
                                                          1, "girl",
                                                          headVariants[1], bodyVariants[1], null,
                                                          null, null, tailVariants[1]),

                                  new AlchemicalComponent("marshmallow",
                                                          2, "horse",
                                                          headVariants[2], bodyVariants[2], null,
                                                          null, null, tailVariants[2]),

                                  new AlchemicalComponent("apple",
                                                          3, "horse",
                                                          headVariants[3], bodyVariants[3], null,
                                                          null, null, tailVariants[3]),

                                  new AlchemicalComponent("pumpkin latte",
                                                          4, "girl",
                                                          headVariants[4], bodyVariants[4], tailVariants[4],
                                                          null, markVariants[0], null),

                                  new AlchemicalComponent("ghost cookies",
                                                          5, "horse",
                                                          headVariants[5], bodyVariants[5], tailVariants[5],
                                                          null, markVariants[1], tailVariants[5]),

                                  new AlchemicalComponent("scented candles",
                                                          6, "horse",
                                                          headVariants[6], bodyVariants[6], null,
                                                          null, null, tailVariants[6]),

                                  new AlchemicalComponent("mushrooms",
                                                          7, "horse",
                                                          null, bodyVariants[7], tailVariants[7],
                                                          headVariants[7], null, null),

                                  new AlchemicalComponent("flaming skull",
                                                          8, "horse",
                                                          null, bodyVariants[8], tailVariants[8],
                                                          headVariants[8], null, null),

                                  new AlchemicalComponent("honeycomb",
                                                          9, "horse",
                                                          headVariants[9], bodyVariants[9], tailVariants[9],
                                                          null, null, null),

                                  new AlchemicalComponent("cinnamon",
                                                          10, "horse",
                                                          headVariants[10], bodyVariants[10], null,
                                                          null, null, tailVariants[6]),

                                  new AlchemicalComponent("lime",
                                                          11, "small",
                                                          headVariants[11], bodyVariants[11], null,
                                                          null, null, tailVariants[11]),

                                  new AlchemicalComponent("tarantula plushie",
                                                          12, "horse",
                                                          headVariants[12], bodyVariants[12], null,
                                                          null, null, tailVariants[12]),
        };

        DontDestroyOnLoad(this);
    }

}
