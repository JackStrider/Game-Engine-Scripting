using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(0.1f, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(-0.1f, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(-0.1f, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(0.1f, 0, 0);
        //}
        //if (Input.GetButton("Horizontal"))
        //{
        //    transform.Translate(0.1f, 0, 0);
        //}

        float horizontalInput = Input.GetAxis("Horizontal");

        Debug.Log("horizontal input: " + horizontalInput);



        float speed = 0.2f;

        transform.Translate(speed * horizontalInput, 0, 0);



        if (Input.GetButtonDown("Jump"))
        {
            transform.Translate(0, 6, 0);
        }
    }
}
