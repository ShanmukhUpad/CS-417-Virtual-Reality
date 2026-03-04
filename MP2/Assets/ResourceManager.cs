using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public float researchPoints = 0f;
    public float researchRate = 5f;   // Increase for testing

    public GameObject energyUI;
    public bool energyUnlocked = false;

    void Update()
    {
        // Euler Integration
        researchPoints += 20f * Time.deltaTime;

        // Unlock second resource
        if (!energyUnlocked && researchPoints >= 100f)
        {
            energyUnlocked = true;

            if (energyUI != null)
                energyUI.SetActive(true);
        }
    }

    public void AddRate(float amount)
    {
        researchRate += amount;
    }

    public bool SpendResearch(float amount)
    {
        if (researchPoints >= amount)
        {
            researchPoints -= amount;
            return true;
        }
        return false;
    }
}