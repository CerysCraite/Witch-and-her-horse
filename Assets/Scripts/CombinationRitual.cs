using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CombinationRitual : MonoBehaviour
{
    public AlchemicalComponent essence, reagent, catalyst;

    [SerializeField] GameObject horse; 
    Transform headAnchor, tailAnchor, markAnchor, bodyAnchor;

    private void Start()
    {
        headAnchor = horse.transform.GetChild(0);
        tailAnchor = horse.transform.GetChild(1);
        markAnchor = horse.transform.GetChild(2);
        bodyAnchor = horse.transform.GetChild(3);
    }

    public void Combine()
    {
        if (essence != null && reagent != null && catalyst != null)
        {
            GameObject newHead = null, newBody = null, newTail = null, newMark = null;

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
                newHead = reagent.reagentHead;
            }
            if (reagent.reagentBody != null)
            {
                GameObject.Destroy(GameObject.FindGameObjectWithTag("Body"));
                newBody = reagent.reagentBody;
            }
            if (reagent.reagentTail != null)
            {
                GameObject.Destroy(GameObject.FindGameObjectWithTag("Tail"));
                newTail = reagent.reagentTail;
            }

            //catalyst changes
            if (catalyst.catalystHead != null)
            {
                GameObject.Destroy(GameObject.FindGameObjectWithTag("Head"));
                newHead = catalyst.catalystHead;               
            }
            if (catalyst.catalystMark != null)
            {
                GameObject.Destroy(GameObject.FindGameObjectWithTag("Mark"));
                newMark = catalyst.catalystMark;
            }
            if (catalyst.catalystTail != null)
            {
                GameObject.Destroy(GameObject.FindGameObjectWithTag("Tail"));
                newTail = catalyst.catalystTail;
            }

            if (newHead)
                GameObject.Instantiate(newHead, headAnchor);
            if (newBody)
                GameObject.Instantiate(newBody, bodyAnchor);
            if (newTail)
                GameObject.Instantiate(newTail, tailAnchor);
            if (newMark)
                GameObject.Instantiate(newMark, markAnchor);
        }
    }
}
