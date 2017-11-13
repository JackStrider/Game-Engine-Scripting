using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerController : MonoBehaviour {

    public float maxSpeed = 10f;
    bool facingRight = true;
    private Rigidbody2D myRigidBody2D;

    Animator anim;

    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce = 700;

    bool doubleJump = false;
    public bool DoubleJumpItem = false;

    private AudioSource audioSource;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        myRigidBody2D = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", grounded);

        if (grounded)
            doubleJump = false;

        if (DoubleJumpItem == false)
            doubleJump = true;        

        anim.SetFloat("vSpeed", myRigidBody2D.velocity.y);

        float move = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", Mathf.Abs(move));

        myRigidBody2D.velocity = new Vector2(move * maxSpeed, myRigidBody2D.velocity.y);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
	}

    void Update()
    {       
        if((grounded || !doubleJump) && Input.GetKeyDown(KeyCode.Space))
        {
                anim.SetBool("Ground", false);
                myRigidBody2D.AddForce(new Vector2(0, jumpForce));
                audioSource.Play();

            if (!doubleJump && !grounded)
            {
                doubleJump = true;
                audioSource.Play();
            }
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}