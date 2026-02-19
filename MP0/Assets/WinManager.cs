using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class WinManager : MonoBehaviour
{
    public XRSocketInteractor socket1;
    public XRSocketInteractor socket2;

    public GameObject winUI;

    private bool hasWon = false;

    private void OnEnable()
    {
        socket1.selectEntered.AddListener(CheckWin);
        socket2.selectEntered.AddListener(CheckWin);
    }

    void CheckWin(UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs args)
    {
        if (hasWon) return;

        if (socket1.hasSelection && socket2.hasSelection)
        {
            TriggerWin();
        }
    }

    void TriggerWin()
    {
        hasWon = true;

        if (winUI != null)
            winUI.SetActive(true);
    }
}
