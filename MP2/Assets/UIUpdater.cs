using UnityEngine;
using TMPro;

public class UIUpdater : MonoBehaviour
{
    public ResourceManager manager;
    public TextMeshProUGUI text;

    void Update()
    {
        text.text = "Research: " + manager.researchPoints.ToString("F1");
    }
}