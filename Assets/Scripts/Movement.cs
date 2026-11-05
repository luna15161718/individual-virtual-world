using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    Vector3 MoveAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.position += MoveAmount;
    }

    void OnMove(InputValue value)
    {
        MoveAmount = new Vector3(value.Get<Vector2>().x, 0, value.Get<Vector2>().y) * 5;
    }
}
