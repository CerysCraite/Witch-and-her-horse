using UnityEngine;

public class SpawnDatakeeper : MonoBehaviour
{
    [SerializeField] GameObject dataKeeper;
    void Start()
    {
        var search = GameObject.FindAnyObjectByType<Components>();
        if (search == null)
            GameObject.Instantiate(dataKeeper);

    }
}
