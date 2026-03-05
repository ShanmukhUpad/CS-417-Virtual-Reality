using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public ResourceManager manager;

    public TextMeshProUGUI redText;
    public TextMeshProUGUI blueText;
    public TextMeshProUGUI greenText;

    public Image blueSphere;
    public Image greenSphere;

    private Color grayColor = new Color(0.4f, 0.4f, 0.4f, 1f);
    private Color blueColor = new Color(0f, 0.4f, 1f, 1f);
    private Color greenColor = new Color(0f, 1f, 0.3f, 1f);

    void Update()
    {
        if (manager == null) return;

        // Update numbers only
        redText.text = ": " + manager.redLiquid.ToString("F0");
        blueText.text = ": " + manager.blueLiquid.ToString("F0");
        greenText.text = ": " + manager.greenLiquid.ToString("F0");

        // Sphere colors
        blueSphere.color = manager.generatingBlue ? blueColor : grayColor;
        greenSphere.color = manager.generatingGreen ? greenColor : grayColor;
    }
}