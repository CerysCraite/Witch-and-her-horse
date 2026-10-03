using UnityEngine;

public class Materials : MonoBehaviour
{
    public static Material[] materials = new Material[13];
    [SerializeField] Material[] materialReferences;

    private void Start()
    {
        for (int i = 0; i < materialReferences.Length; i++)
        {
            materials[i] = materialReferences[i];
            Debug.Log(materials[i]);
        }

    }  
}
