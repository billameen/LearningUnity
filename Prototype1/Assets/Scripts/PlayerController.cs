using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    

    public float speed = 10;
    public float turnSpeed = 100;
    public InputAction MoveAction;
    private Vector2 moveInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveAction.Enable();
    }


    // Update is called once per frame
    void Update()
    {
        moveInput = MoveAction.ReadValue<Vector2>();
        //forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }
}
