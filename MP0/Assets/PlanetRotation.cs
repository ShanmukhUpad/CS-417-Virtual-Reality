using UnityEngine.InputSystem;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float rotationSpeed = 40f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
