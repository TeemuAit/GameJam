using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D theRB;
    public float jumpForce;
    public Rigidbody2D rigidbody2d;

    private bool isGrounded;
    public Transform groundCheckPoint;
    public LayerMask whatIsGround;

    private bool canDoubleJump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), theRB.velocity.y);

        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .2f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 10f;
            theRB.velocity = Vector2.up * jumpVelocity;
        }

        //if (isGrounded)
        //{
        //    canDoubleJump = true;
        //}

        //if (Input.GetButtonDown("Jump"))
        //{
        //    theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
        //}
        //else
        //{
        //    if (canDoubleJump)
        //    {
        //        theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
        //        canDoubleJump = false;
        //    }
        //}
    }
}
