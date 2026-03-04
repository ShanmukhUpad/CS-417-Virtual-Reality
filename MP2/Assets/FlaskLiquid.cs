using UnityEngine;

public class FlaskLiquid : MonoBehaviour
{
    public ResourceManager manager;
    public float maxResourceForFull = 50f;  // Lower for testing

    private float fullHeight;

    void Start()
    {
        // Make sure object is set to FULL height in editor before play
        fullHeight = transform.localScale.y;

        // Start empty
        SetLiquidHeight(0f);
    }

    void Update()
    {
        if (manager == null) return;

        float percent = Mathf.Clamp01(manager.researchPoints / maxResourceForFull);
        SetLiquidHeight(percent);
    }

    void SetLiquidHeight(float percent)
    {
        float newHeight = fullHeight * percent;

        // Set scale
        transform.localScale = new Vector3(
            transform.localScale.x,
            newHeight,
            transform.localScale.z
        );

        // Move upward so bottom stays fixed
        transform.localPosition = new Vector3(
            transform.localPosition.x,
            newHeight / 2f,
            transform.localPosition.z
        );
    }
}