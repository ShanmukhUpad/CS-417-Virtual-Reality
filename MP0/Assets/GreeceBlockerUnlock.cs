using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class GreeceBlockerUnlock : MonoBehaviour
{
    public XRSocketInteractor socket;

    void Update()
    {
        if (socket.hasSelection)
        {
            GameObject insertedKey = socket.GetOldestInteractableSelected().transform.gameObject;

            Destroy(insertedKey);
            Destroy(gameObject);
        }
    }
}
