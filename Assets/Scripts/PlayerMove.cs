using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    [SerializeField]
    private float speed = 0.2f;

    [SerializeField]
    private float jumpHight = 6;

    private Rigidbody2D myRigidBody2D;

    private bool isOnGround;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        isOnGround = true;

    }
    
    private void MyNewFunction(Collision2D collision)
    {



    }

    

    // Use this for initialization
    void Start ()
    {

        myRigidBody2D = GetComponent<Rigidbody2D>();
              
	}

    

    // Update is called once per frame
    void Update () {
        
        float horizontalInput = Input.GetAxis("Horizontal");

        Debug.Log("horizontal input: " + horizontalInput);





        // Refactoring to use the unity physics system...
        //transform.Translate(speed * horizontalInput, 0, 0);

        myRigidBody2D.velocity = 
            new Vector2(speed * horizontalInput, myRigidBody2D.velocity.y);




        if (Input.GetButtonDown("Jump") && isOnGround)
        {
            myRigidBody2D.velocity = new Vector2(myRigidBody2D.velocity.x, jumpHight);

            isOnGround = false;
        }
    }
}


public class Player
{
    
    private int numberOfLives = 3;
    private float hitPoints = 100;
    private float money = 20;

    public void TakeDamage(float amountOfDamage)
    {
        hitPoints -= amountOfDamage;
    }

}


public class Enemy
{
    [SerializeField]
    float attackDamage = 5;

    private void DamagePlayer(Player playerWeTouched)
    {
        
        playerWeTouched.TakeDamage(attackDamage);
    }

}