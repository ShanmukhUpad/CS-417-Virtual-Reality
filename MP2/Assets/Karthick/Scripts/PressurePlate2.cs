using UnityEngine;

public class PressurePlate2 : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Transform spawnPoint;

    public ResourceManager resourceManager;  // Reference to manager
    public float requiredResearch = 100f;    // Requirement

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Make sure manager exists
            if (resourceManager == null) return;

            // Check requirement
            if (resourceManager.researchPoints >= requiredResearch)
            {
                Debug.Log("Second plate activated!");
                resourceManager.StartGenerating();
                SpawnObject();
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Not enough research to activate this plate.");
            }
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