using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Transform objectToFollow;

    [SerializeField]
    float yOffSet;

    [SerializeField]
    float xOffSet;

    float zOffset;
	// Use this for initialization
	void Start ()
    {
        zOffset = transform.position.z;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 newPosition = 
            new Vector3(objectToFollow.position.x + xOffSet, objectToFollow.position.y +yOffSet, zOffset);
        transform.position = newPosition;
	}
}
