using UnityEngine;
using TMPro;

public class ResourceUI : MonoBehaviour
{
    public ResourceManager manager;
    public TextMeshProUGUI researchText;

    void Update()
    {
        if (manager == null) return;

        researchText.text = "Research: " + manager.researchPoints.ToString("F0");
    }
}