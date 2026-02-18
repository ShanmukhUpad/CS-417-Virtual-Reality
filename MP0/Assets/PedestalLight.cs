using UnityEngine;


public class PedestalLight : MonoBehaviour
{
    public GameObject lightObject;
    private UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socket;

    void Start()
    {
        socket = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>();
        lightObject.SetActive(false);
    }

    void Update()
    {
        if (socket.hasSelection)
            lightObject.SetActive(true);
        else
            lightObject.SetActive(false);
    }
}
