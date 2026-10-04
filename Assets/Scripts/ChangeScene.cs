using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void GatherComponents()
    {
        SceneManager.LoadScene("Gathering");
    }

    public void PerformRitual()
    {
        SceneManager.LoadScene("Ritual");
    }

    public void Quitl()
    {
        Application.Quit();
    }
}
