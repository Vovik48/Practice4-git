using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 25f;
    public float jumpForce = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector2 moveInput = Vector2.zero;
        Vector3 rotate = Vector3.zero;

        if (Keyboard.current != null)
        {
            if (Keyboard.current.wKey.isPressed) moveInput.y = 1;
            if (Keyboard.current.sKey.isPressed) moveInput.y = -1;
            if (Keyboard.current.aKey.isPressed) moveInput.x = -1;
            if (Keyboard.current.dKey.isPressed) moveInput.x = 1;
            if (Keyboard.current.qKey.isPressed) rotate.y = 1;
            if (Keyboard.current.eKey.isPressed) rotate.y = -1;
        }

        Vector3 movement = new Vector3(moveInput.x, 0, moveInput.y);
        transform.Translate(movement * speed * Time.deltaTime);
        transform.Rotate(rotate * rotationSpeed * Time.deltaTime);

        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}