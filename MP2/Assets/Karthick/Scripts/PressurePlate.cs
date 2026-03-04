using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [Header("Spawn Settings")]
    public GameObject prefabToSpawn;
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        // 1. Check if the object touching the plate is the Player
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player triggered the plate. Spawning object and self-destructing.");

            SpawnObject();

            // 2. Destroy the pressure plate itself so it can't be used again
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