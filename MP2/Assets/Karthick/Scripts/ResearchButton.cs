using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ResearchButton : MonoBehaviour
{
    public ResourceManager resourceManager;

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable;

    void Awake()
    {
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
        interactable.selectEntered.AddListener(OnPressed);
    }

    void OnPressed(SelectEnterEventArgs args)
    {
        if (resourceManager != null)
        {
            resourceManager.researchPoints += 1f;
        }
    }
}