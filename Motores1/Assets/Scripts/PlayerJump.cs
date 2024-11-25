using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f; 
    public bool isGrounded = true; 
    public Transform groundCheck; 
    public LayerMask groundMask; 
    public float groundDistance = 0.4f; 

    private Rigidbody rb;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }
    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }


}
