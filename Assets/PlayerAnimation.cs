using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimation : MonoBehaviour
{
    private Animator npcAnimator;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        npcAnimator ??= Object.FindAnyObjectByType<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current != null)
        {
            if (Keyboard.current.wKey.isPressed)
            {
                Debug.Log("StartWalk");
                npcAnimator.SetTrigger("StartWalk");
            }
            if (Keyboard.current.wKey.wasReleasedThisFrame)
            {
                Debug.Log("EndWalk");
                npcAnimator.SetTrigger("EndWalk");
            }
            //if (rb.)
        }

        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            //Jump();
        }
    }
}
