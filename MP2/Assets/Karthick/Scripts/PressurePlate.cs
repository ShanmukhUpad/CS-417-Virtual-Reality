using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [Header("Spawn Settings")]
    public GameObject prefabToSpawn;
    public Transform spawnPoint;

    public ResourceManager resourceManager;  // NEW

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player triggered the plate.");

            // Start resource generation
            if (resourceManager != null)
            {
                resourceManager.StartGenerating();
            }

            SpawnObject();
            Destroy(gameObject);
        }
    }

    void SpawnObject()
    {
        if (prefabToSpawn != null && spawnPoint != null)
        {
            Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);
        }
        else
        {
            Debug.LogWarning("Execution failed: Prefab or SpawnPoint is missing on " + gameObject.name);
        }
    }
}