using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    // =============================
    // LIQUID AMOUNTS
    // =============================

    public float redLiquid = 0f;
    public float blueLiquid = 0f;
    public float greenLiquid = 0f;


    // =============================
    // GENERATION RATES
    // =============================

    public float redRate = 10f;
    public float blueRate = 10f;
    public float greenRate = 10f;


    // =============================
    // GENERATION STATES
    // =============================

    public bool generatingRed = false;
    public bool generatingBlue = false;
    public bool generatingGreen = false;


    void Update()
    {
        if (generatingRed)
        {
            redLiquid += redRate * Time.deltaTime;
        }

        if (generatingBlue)
        {
            blueLiquid += blueRate * Time.deltaTime;
        }

        if (generatingGreen)
        {
            greenLiquid += greenRate * Time.deltaTime;
        }
    }


    // =============================
    // START GENERATION
    // =============================

    public void StartRedGeneration()
    {
        generatingRed = true;
    }

    public void StartBlueGeneration()
    {
        generatingBlue = true;
    }

    public void StartGreenGeneration()
    {
        generatingGreen = true;
    }


    // =============================
    // UPGRADE RATES
    // =============================

    public void AddRedRate(float amount)
    {
        redRate += amount;
    }

    public void AddBlueRate(float amount)
    {
        blueRate += amount;
    }

    public void AddGreenRate(float amount)
    {
        greenRate += amount;
    }


    // =============================
    // SPENDING METHODS
    // =============================

    public bool SpendRed(float amount)
    {
        if (redLiquid >= amount)
        {
            redLiquid -= amount;
            return true;
        }
        return false;
    }

    public bool SpendBlue(float amount)
    {
        if (blueLiquid >= amount)
        {
            blueLiquid -= amount;
            return true;
        }
        return false;
    }

    public bool SpendGreen(float amount)
    {
        if (greenLiquid >= amount)
        {
            greenLiquid -= amount;
            return true;
        }
        return false;
    }


    // =============================
    // MULTI-LIQUID CHECK
    // =============================

    public bool CanAfford(float redCost, float blueCost, float greenCost)
    {
        return redLiquid >= redCost &&
               blueLiquid >= blueCost &&
               greenLiquid >= greenCost;
    }

    public void SpendMultiple(float redCost, float blueCost, float greenCost)
    {
        redLiquid -= redCost;
        blueLiquid -= blueCost;
        greenLiquid -= greenCost;
    }
}