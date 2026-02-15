using UnityEngine;

public class PedestalLight : MonoBehaviour
{
    public GameObject lightObject;   // Drag your light here
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateLight()
    {
        lightObject.SetActive(true);
    }
}
