using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    private float sensitivity = 0.15f;
    private float xRotation = 0f;

    void Start()
    {
    
    } 

    void Update()
    {
        Vector2 mouseDelta = Mouse.current.delta.ReadValue();
        float lookY = mouseDelta.y;

        // Arrow key fallback
        if (Keyboard.current.upArrowKey.isPressed) lookY -= 5f;
        if (Keyboard.current.downArrowKey.isPressed) lookY += 5f;

        xRotation -= lookY * sensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
