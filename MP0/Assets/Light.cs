using UnityEngine;
using UnityEngine.InputSystem;

public class LightController : MonoBehaviour
{
    public InputActionReference action;
    public Light lightComponent;

    private Color[] colors;
    private int currentIndex = 0;

    void Start()
    {
        if (lightComponent == null)
            lightComponent = GetComponent<Light>();

        if (lightComponent == null)
        {
            Debug.LogError("No Light component found on this GameObject!");
            return;
        }

        // Store original color and define cycle
        colors = new Color[]
        {
            lightComponent.color, // original lighting
            Color.red,
            Color.green,
            Color.blue
        };

        action.action.Enable();
        action.action.performed += ctx => CycleLightColor();
    }

    void CycleLightColor()
    {
        currentIndex = (currentIndex + 1) % colors.Length;
        lightComponent.color = colors[currentIndex];
    }
}
