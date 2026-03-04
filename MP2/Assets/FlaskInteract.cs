using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FlaskInteract : MonoBehaviour
{
    public ResourceManager resourceManager;

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable;

    void Awake()
    {
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
        interactable.selectEntered.AddListener(OnFlaskTouched);
    }

    void OnFlaskTouched(SelectEnterEventArgs args)
    {
        if (resourceManager != null)
        {
            resourceManager.redLiquid += 1f;
        }
    }
}