using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class KeyboardMove : MonoBehaviour
{
    private float moveSpeed = 2f;

    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = Vector3.zero;

        if (Keyboard.current.wKey.isPressed) move += Vector3.forward;
        if (Keyboard.current.sKey.isPressed) move += Vector3.back;
        if (Keyboard.current.aKey.isPressed) move += Vector3.left;
        if (Keyboard.current.dKey.isPressed) move += Vector3.right;

        // move relative to headset facing direction
        Transform cameraTransform = Camera.main.transform;
        Vector3 direction = cameraTransform.forward * move.z + cameraTransform.right * move.x;
        direction.y = 0f;

        controller.Move(direction * moveSpeed * Time.deltaTime);
    }
}
