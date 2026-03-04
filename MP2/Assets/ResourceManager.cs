using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public float researchPoints = 0f;
    public float researchRate = 5f;

    public bool generating = false;   // NEW

    public GameObject energyUI;
    public bool energyUnlocked = false;

    void Update()
    {
        // Only generate if activated
        if (generating)
        {
            researchPoints += researchRate * Time.deltaTime;
        }

        // Unlock second resource
        if (!energyUnlocked && researchPoints >= 100f)
        {
            energyUnlocked = true;

            if (energyUI != null)
                energyUI.SetActive(true);
        }
    }

    public void StartGenerating()
    {
        generating = true;
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