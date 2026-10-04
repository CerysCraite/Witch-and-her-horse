using UnityEngine;

public class ResetHorse : MonoBehaviour
{
    Transform headAnchor, tailAnchor, bodyAnchor;
    [SerializeField] GameObject horse;
    [SerializeField] GameObject horseFrame;
    [SerializeField] GameObject baseHead;
    [SerializeField] GameObject baseBody;
    [SerializeField] GameObject baseTail;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        horse = GameObject.FindGameObjectWithTag("Horse");
        ResetHorseState();
    }

    public void ResetHorseState()
    {
        GameObject.Destroy(GameObject.FindGameObjectWithTag("Head"));
        GameObject.Destroy(GameObject.FindGameObjectWithTag("Body"));
        GameObject.Destroy(GameObject.FindGameObjectWithTag("Mark"));
        GameObject.Destroy(GameObject.FindGameObjectWithTag("Tail"));

        if(horse == null)
        {
            var newFrame = GameObject.Instantiate(horseFrame);
            horse = newFrame;
        }

        headAnchor = horse.transform.GetChild(0);
        tailAnchor = horse.transform.GetChild(1);
        bodyAnchor = horse.transform.GetChild(3);

        GameObject.Instantiate(baseHead, headAnchor);
        GameObject.Instantiate(baseBody, bodyAnchor);
        GameObject.Instantiate(baseTail, tailAnchor);
    }
}
