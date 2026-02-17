using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class MedievalRoomManager : MonoBehaviour
{
    public XRSocketInteractor swordSocket;
    public XRSocketInteractor shieldSocket;
    public XRSocketInteractor crownSocket;

    public GameObject greeceKey;

    private bool keySpawned = false;

    void Start()
    {
        greeceKey.SetActive(false);
    }


    void Update()
    {
        if (!keySpawned &&
            swordSocket.hasSelection &&
            shieldSocket.hasSelection &&
            crownSocket.hasSelection)
        {
            keySpawned = true;
            greeceKey.SetActive(true);
        }
    }
}
