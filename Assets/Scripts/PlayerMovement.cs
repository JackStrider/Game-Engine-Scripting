using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    float Speed = 1;

    [SerializeField]
    Rigidbody2D MyRigidbody;
	// Use this for initialization
	void Start ()
    {
        // Debug.Log("Called from Start.");
        //This code teleports the gameobject to a new location.
        //transform.position = new Vector3(0, 0, 0);
      //  MyRigidbody = GetComponent<Rigidbody2D>();

	}
	// Update is called once per frame
	void Update ()
    {
        // Dont use GETKEY use GetButton or Axis
        // Debug.Log("Called from Update");
        //Moves the gameobject at a 0.1f movement
        //  transform.Translate(new Vector3(0.1f, 0, 0))
        /* if (Input.GetKey(KeyCode.D))
         {
             transform.Translate(new Vector3(0.1f, 0, 0));
         }
         if (Input.GetKey(KeyCode.A))
         {
             transform.Translate(new Vector3(-0.1f, 0, 0));
         }*/
        // This method of movement doesnt use physics system.
        //transform.Translate(0.1f * horizontalInput, 0, 0);
        
        float horizontalInput = Input.GetAxis("Horizontal");
        MyRigidbody.velocity = 
            new Vector2(horizontalInput * Speed, MyRigidbody.velocity.y);
        

        Debug.Log("Horizintal input" + horizontalInput);

        if (Input.GetButtonDown("Jump"))
        {
            //crappy jump logic
            //transform.Translate(0, 3, 0);
        }
        
       
    }
}
