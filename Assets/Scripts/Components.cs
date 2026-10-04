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

    public Sprite componentIcon;

    public AlchemicalComponent(string name, int essenceColour, string horseFrame, GameObject reagentAddHead, GameObject reagentAddBody, GameObject reagentAddTail, GameObject catalystAddHead, GameObject catalystAddMark, GameObject catalystAddTail, Sprite icon)
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
        componentIcon = icon;
    }

}

public class Components : MonoBehaviour
{
    public AlchemicalComponent[] alchemicalComponents = new AlchemicalComponent[13];
    public GameObject[] headVariants;
    public GameObject[] bodyVariants;
    public GameObject[] tailVariants;
    public GameObject[] markVariants;
    public Sprite[] componentIcons;

    public AlchemicalComponent[] unlockedComponents = new AlchemicalComponent[13];
    public static List<string> availableComponents = new List<string> {null};

    private void Start()
    {
        Debug.Log("fuck");
        alchemicalComponents = new AlchemicalComponent[]{
                                  new AlchemicalComponent("jackolantern",
                                                          0, "horse",
                                                          null, bodyVariants[0], tailVariants[0],
                                                          headVariants[0], null, null,
                                                          componentIcons[0]),

                                  new AlchemicalComponent("chamomile tea",
                                                          1, "girl",
                                                          headVariants[1], bodyVariants[1], null,
                                                          null, markVariants[0], tailVariants[1],
                                                          componentIcons[1]),

                                  new AlchemicalComponent("marshmallow",
                                                          2, "horse",
                                                          headVariants[2], bodyVariants[2], null,
                                                          null, null, tailVariants[2],
                                                          componentIcons[2]),

                                  new AlchemicalComponent("apple",
                                                          3, "horse",
                                                          headVariants[3], bodyVariants[3], null,
                                                          null, null, tailVariants[3],
                                                          componentIcons[3]),

                                  new AlchemicalComponent("pumpkin latte",
                                                          4, "girl",
                                                          headVariants[4], bodyVariants[4], tailVariants[4],
                                                          null, markVariants[1], null,
                                                          componentIcons[4]),

                                  new AlchemicalComponent("ghost cookies",
                                                          5, "horse",
                                                          headVariants[5], bodyVariants[5], tailVariants[5],
                                                          null, markVariants[2], tailVariants[5],
                                                          componentIcons[5]),

                                  new AlchemicalComponent("scented candles",
                                                          6, "horse",
                                                          headVariants[6], bodyVariants[6], null,
                                                          null, null, tailVariants[6],
                                                          componentIcons[6]),

                                  new AlchemicalComponent("mushrooms",
                                                          7, "horse",
                                                          null, bodyVariants[7], tailVariants[7],
                                                          headVariants[7], null, null,
                                                          componentIcons[7]),

                                  new AlchemicalComponent("flaming skull",
                                                          8, "horse",
                                                          null, bodyVariants[8], tailVariants[8],
                                                          headVariants[8], null, null,
                                                          componentIcons[8]),

                                  new AlchemicalComponent("honeycomb",
                                                          9, "horse",
                                                          headVariants[9], bodyVariants[9], tailVariants[9],
                                                          null, markVariants[3], null,
                                                          componentIcons[9]),

                                  new AlchemicalComponent("cinnamon",
                                                          10, "horse",
                                                          headVariants[10], bodyVariants[10], null,
                                                          null, null, tailVariants[10],
                                                          componentIcons[10]),

                                  new AlchemicalComponent("lime",
                                                          11, "small",
                                                          headVariants[11], bodyVariants[11], null,
                                                          null, null, tailVariants[11],
                                                          componentIcons[11]),

                                  new AlchemicalComponent("tarantula plushie",
                                                          12, "horse",
                                                          headVariants[12], bodyVariants[12], null,
                                                          null, null, tailVariants[12],
                                                          componentIcons[12]),
        };

        DontDestroyOnLoad(this);
    }

}
