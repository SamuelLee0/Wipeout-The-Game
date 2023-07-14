using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;//variable called rb 
    [SerializeField] float movementSpeed = 6f;//movementspeed variable
    [SerializeField] float jumpForce = 5f;//jump highet variable

    [SerializeField] Transform groundCheck;//variable called ground check that can be edited from outside the script
    [SerializeField] LayerMask ground;//variable called ground that can be edited from outside the script

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();//assigns the rigid body of the parent of the script to the variable rb
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");//variable that imports all the horizontal movements that unity has available
        float verticalInput = Input.GetAxis("Vertical");//variable that imports all the horizontal movements that unity has available

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);//variable called rb.velocity that has the equation for the players velocity

        if (Input.GetButtonDown("Jump") && IsGrounded())//if statement that checks if the user is sending the input "space" and checking to see if the bool isgrounded is set to true
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
    }

    bool IsGrounded()//bool called isgrounded
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);//bool is true if there is a sphere that is connected to the ground
    }

}
