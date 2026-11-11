using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    Vector3 moveAmount;
    CharacterController controller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.rotation = Camera.main.transform.rotation;
        controller.Move(transform.TransformDirection(moveAmount));
        if(!controller.isGrounded) {
            controller.Move(new Vector3(0, -2, 0));
        }
    }

    void OnMove(InputValue value)
    {
        moveAmount = Vector3.ProjectOnPlane((new Vector3((value.Get<Vector2>().x), 0, (value.Get<Vector2>().y)) * 0.5f), Vector3.up);
    }
}
