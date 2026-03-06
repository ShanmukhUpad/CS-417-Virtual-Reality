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

    private Color grayColor = new Color(0.4f, 0.4f, 0.4f, 1f);
    private Color blueColor = new Color(0f, 0.4f, 1f, 1f);
    private Color greenColor = new Color(0f, 1f, 0.3f, 1f);
    void Start()
{
    if (redText != null) redText.rectTransform.anchoredPosition = new Vector2(-200, 200);
    if (blueText != null) blueText.rectTransform.anchoredPosition = new Vector2(0, 200);
    if (greenText != null) greenText.rectTransform.anchoredPosition = new Vector2(200, 200);
    blueSphere.rectTransform.anchoredPosition = new Vector2(0, 150);
}
   void Update()
{
    if (manager == null) return;
    redText.text = "R: " + manager.redLiquid.ToString("F0");
    blueText.text = "B: " + manager.blueLiquid.ToString("F0");
    greenText.text = "G: " + manager.greenLiquid.ToString("F0");

    if (manager.generatingGreen) 
    {
        blueSphere.color = Color.green; 
    }
    else if (manager.generatingBlue) 
    {
        blueSphere.color = Color.blue; 
    }
    else if (manager.generatingRed) 
{
    Debug.Log("Sphere should be red");
    blueSphere.color = Color.red; 
}
    else 
    {
        blueSphere.color = Color.gray; 
    }
}
}