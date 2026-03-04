using UnityEngine;
using TMPro;

public class PressurePlate2 : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Transform spawnPoint;

    public ResourceManager resourceManager;

    public float requiredResearch = 100f;
    public float upgradeAmount = 2f;     // How much rate increases each time

    public TextMeshPro textDisplay;

    private bool hasSpawned = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        if (resourceManager == null) return;

        // Require research to use
        if (resourceManager.researchPoints < requiredResearch)
        {
            if (textDisplay != null)
                textDisplay.text = "Need 100 Research";
            return;
        }

        // Spend research cost (optional but recommended)
        resourceManager.SpendResearch(requiredResearch);

        // FIRST TIME → Spawn Generator
        if (!hasSpawned)
        {
            SpawnObject();
            resourceManager.StartGenerating();

            hasSpawned = true;

            if (textDisplay != null)
                textDisplay.text = "Generator Built!";
        }
        else
        {
            // AFTER FIRST TIME → Upgrade rate
            resourceManager.AddRate(upgradeAmount);

            if (textDisplay != null)
                textDisplay.text = "Upgraded! +" + upgradeAmount + " Rate";
        }
    }

    void SpawnObject()
    {
        if (prefabToSpawn != null && spawnPoint != null)
        {
            Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);
        }
    }
}