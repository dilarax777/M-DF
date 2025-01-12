using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float playerHeight = 2f;
    static public float movementSpeed = 6f;
    public float movementMultiplier = 10f;
    [SerializeField] float airMultiplier = 0.4f;
    
    public float jumpForce = 5f;
    
    float verticalMovement; 
    float horizontalMovement;
   
    [SerializeField] float groundDrag = 6f;
    [SerializeField] float airDrag = 2f;
   
    Vector3 moveDirection;
   
    Rigidbody rb; 
    bool isGrounded;
    [SerializeField] LayerMask groundMask;
    float groundDistance = 0.4f;
    static public bool dialogue

    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {

        isGrounded = Physics.CheckSphere(transform - position - new Vector3(0, playerHeight / 2, 0), groundDistance, groundMask);
        
        My Input();
        ControlDrag();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
            
    }
    void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }



    void MyInput()
    {
        //Computer
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");
        //Mobile
        //horizontalMovement = joystick.Horizontal;
        //verticalMovement = joystick.Vertical;
        
        moveDirection = transform.forward * verticalMovement + transform.right * horizontalMovement;


    }

    private void FixedUpdate()
    {
        if (!dialogue)
        {
            MovePlayer();

        }
    }



    void MovePlayer()
    {
        if (isGrounded)
        { 
            rb.AddForce(moveDirection * movementSpeed * movementMultiplier, ForceMode.Acceleration); 
        }
        else
        {
            rb.AddForce(moveDirection * movementSpeed * movementMultiplier * airMultiplier, ForceMode.Acceleration);
        }

    }

}
