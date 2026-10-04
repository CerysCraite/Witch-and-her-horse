using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CombinationRitual : MonoBehaviour
{
    public AlchemicalComponent essence, reagent, catalyst;

    [SerializeField] GameObject horseMain;
    [SerializeField] GameObject horseGirl;
    [SerializeField] GameObject horseSmall;
    string currentFrame = "horse";
    GameObject horse;
    ParticleSystem smoke;
    Transform headAnchor, tailAnchor, markAnchor, bodyAnchor;

    private void Start()
    {
        GetHorseFrame(GameObject.FindGameObjectWithTag("Horse"));
        smoke = GameObject.Find("Smoke").GetComponent<ParticleSystem>();
    }

    public void GetHorseFrame(GameObject newHorse)
    {
        horse = newHorse;
        headAnchor = horse.transform.GetChild(0);
        tailAnchor = horse.transform.GetChild(1);
        markAnchor = horse.transform.GetChild(2);
        bodyAnchor = horse.transform.GetChild(3);
    }
    
    public void Combine()
    {
        if (essence != null && reagent != null && catalyst != null)
        {
            GameObject newHead = null, newBody = null, newTail = null, newMark = null, newFrame = null;

            Debug.Log("starting ritual");

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
            if (reagent.bodyFrame != currentFrame)
            {
                GameObject.Destroy(horse);

                if (reagent.bodyFrame == "horse")
                {
                    newFrame = horseMain;
                    currentFrame = "horse";
                }
                    
                else if (reagent.bodyFrame == "girl")
                {
                    newFrame = horseGirl;
                    currentFrame = "girl";
                }
                    
                else if (reagent.bodyFrame == "small")
                {
                    newFrame = horseSmall;
                    currentFrame = "small";
                }
                    
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

            Debug.Log("spawning parts");
            smoke.Play();

            if(newFrame)
            {
                var newHorse = GameObject.Instantiate(newFrame);
                GetHorseFrame(newHorse);

                Debug.Log(horse.name);

                if (newHead)
                    GameObject.Instantiate(newHead, headAnchor);
                else
                {
                    var head = GameObject.FindGameObjectWithTag("Head");
                    head.transform.position = headAnchor.position;
                    head.transform.parent = headAnchor;
                }
                if (newBody)
                    GameObject.Instantiate(newBody, bodyAnchor);
                else
                {
                    var body = GameObject.FindGameObjectWithTag("Body");
                    body.transform.position = bodyAnchor.position;
                    body.transform.parent = bodyAnchor;
                }
                if (newTail)
                    GameObject.Instantiate(newTail, tailAnchor);
                else
                {
                    var tail = GameObject.FindGameObjectWithTag("Tail");
                    tail.transform.position = tailAnchor.position;
                    tail.transform.parent = tailAnchor;
                }
                if (newMark)
                    GameObject.Instantiate(newMark, markAnchor);
                else
                {
                    var mark = GameObject.FindGameObjectWithTag("Mark");
                    if(mark)
                    {
                        mark.transform.position = markAnchor.position;
                        mark.transform.parent = markAnchor;
                    }              
                }
            }
            else
            {
                if (newHead)
                    GameObject.Instantiate(newHead, headAnchor);
                if (newBody)
                    GameObject.Instantiate(newBody, bodyAnchor);
                if (newTail)
                    GameObject.Instantiate(newTail, tailAnchor);
                if (newMark)
                    GameObject.Instantiate(newMark, markAnchor);
            }
            

            //foundation colour change
            GameObject[] colourableObjects = GameObject.FindGameObjectsWithTag("Colourable");
            foreach (GameObject i in colourableObjects)
            {
                i.transform.GetComponent<SpriteRenderer>().material = Materials.materials[essence.essenceMaterial];
            }
        }
    }
}
