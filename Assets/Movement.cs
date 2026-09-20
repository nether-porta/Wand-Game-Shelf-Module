using UnityEngine;
using UnityEngine.Rendering;

public class Movement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    private float speedScaler = 10f;
    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 movementDirection;

    Rigidbody rb;

    private void Start()
    {
            rb = GetComponent<Rigidbody>();
            rb.freezeRotation = true;

    }

    private void Update()
    {
        Myinput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    private void Myinput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");


    }

    private void MovePlayer()
    {
        movementDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        
    

        
        
        movementDirection.y = rb.linearVelocity.y;
        
        rb.linearVelocity = movementDirection * moveSpeed ;
       
    }

}
