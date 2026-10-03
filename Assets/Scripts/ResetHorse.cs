using UnityEngine;

public class ResetHorse : MonoBehaviour
{
    Transform headAnchor, tailAnchor, bodyAnchor;
    [SerializeField] GameObject horse;
    [SerializeField] GameObject baseHead;
    [SerializeField] GameObject baseBody;
    [SerializeField] GameObject baseTail;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        headAnchor = horse.transform.GetChild(0);
        tailAnchor = horse.transform.GetChild(1);
        bodyAnchor = horse.transform.GetChild(3);

        ResetHorseState();
    }

    public void ResetHorseState()
    {
        GameObject.Destroy(GameObject.FindGameObjectWithTag("Head"));
        GameObject.Destroy(GameObject.FindGameObjectWithTag("Body"));
        GameObject.Destroy(GameObject.FindGameObjectWithTag("Mark"));
        GameObject.Destroy(GameObject.FindGameObjectWithTag("Tail"));

        GameObject.Instantiate(baseHead, headAnchor);
        GameObject.Instantiate(baseBody, bodyAnchor);
        GameObject.Instantiate(baseTail, tailAnchor);
    }
}
