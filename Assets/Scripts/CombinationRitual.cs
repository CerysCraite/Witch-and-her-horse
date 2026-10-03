using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CombinationRitual : MonoBehaviour
{
    public AlchemicalComponent essence, reagent, catalyst;

    [SerializeField] GameObject horse; 
    Transform headAnchor, tailAnchor, markAnchor;

    private void Start()
    {
        headAnchor = horse.transform.GetChild(0);
        tailAnchor = horse.transform.GetChild(1);
        markAnchor = horse.transform.GetChild(2);
    }

    public void Combine()
    {
        if (essence != null && reagent != null && catalyst != null)
        {
            Debug.Log("starting ritual");

            //foundation colour change
            GameObject[] colourableObjects = GameObject.FindGameObjectsWithTag("Colourable");
            foreach (GameObject i in colourableObjects)
            {
                i.transform.GetComponent<SpriteRenderer>().material = Materials.materials[essence.essenceMaterial];
            }

            //reagent changes
            if (reagent.reagentHead != null)
            {
                GameObject.Destroy(GameObject.FindGameObjectWithTag("Head"));
                GameObject.Instantiate(reagent.reagentHead, headAnchor);
            }
            if (reagent.reagentBody != null)
            {
                GameObject.Destroy(GameObject.FindGameObjectWithTag("Body"));
                GameObject.Instantiate(reagent.reagentBody, horse.transform);
            }
            if (reagent.reagentTail != null)
            {
                GameObject.Destroy(GameObject.FindGameObjectWithTag("Tail"));
                GameObject.Instantiate(reagent.reagentTail, tailAnchor);
            }

            //catalyst changes
            if (catalyst.catalystHead != null)
            {
                GameObject.Destroy(GameObject.FindGameObjectWithTag("Head"));
                GameObject.Instantiate(catalyst.catalystHead, headAnchor);
            }
            if (catalyst.catalystMark != null)
            {
                GameObject.Destroy(GameObject.FindGameObjectWithTag("Mark"));
                GameObject.Instantiate(catalyst.catalystMark, markAnchor);
            }
            if (catalyst.catalystTail != null)
            {
                GameObject.Destroy(GameObject.FindGameObjectWithTag("Tail"));
                GameObject.Instantiate(catalyst.catalystTail, tailAnchor);
            }
        }
    }
}
