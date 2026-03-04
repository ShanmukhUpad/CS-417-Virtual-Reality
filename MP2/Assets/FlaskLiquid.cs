using UnityEngine;

public class FlaskLiquid : MonoBehaviour
{
    public enum LiquidType { Red, Blue, Green }
    public LiquidType liquidType;

    public ResourceManager manager;
    public float maxForFull = 50f;

    private float fullHeight;

    void Start()
    {
        fullHeight = transform.localScale.y;
        SetLiquidHeight(0f);
    }

    void Update()
    {
        if (manager == null) return;

        float currentAmount = 0f;

        switch (liquidType)
        {
            case LiquidType.Red:
                currentAmount = manager.redLiquid;
                break;
            case LiquidType.Blue:
                currentAmount = manager.blueLiquid;
                break;
            case LiquidType.Green:
                currentAmount = manager.greenLiquid;
                break;
        }

        float percent = Mathf.Clamp01(currentAmount / maxForFull);
        SetLiquidHeight(percent);
    }

    void SetLiquidHeight(float percent)
    {
        float newHeight = fullHeight * percent;

        transform.localScale = new Vector3(
            transform.localScale.x,
            newHeight,
            transform.localScale.z
        );

        transform.localPosition = new Vector3(
            transform.localPosition.x,
            newHeight / 2f,
            transform.localPosition.z
        );
    }
}