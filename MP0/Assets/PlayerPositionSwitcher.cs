using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPositionSwitcher : MonoBehaviour
{
    public Transform roomPosition;
    public Transform externalPosition;
    public InputActionReference switchAction;

    private bool isExternal = false;

    void Start()
    {
        switchAction.action.Enable();
        switchAction.action.performed += ctx => SwitchPosition();

        transform.position = roomPosition.position;
        transform.rotation = roomPosition.rotation;
    }

    void SwitchPosition()
    {
        if (isExternal)
        {
            transform.position = roomPosition.position;
            transform.rotation = roomPosition.rotation;
        }
        else
        {
            transform.position = externalPosition.position;
            transform.rotation = externalPosition.rotation;
        }

        isExternal = !isExternal;
    }
}
