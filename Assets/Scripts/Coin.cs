using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //Step 1: Declare variables
    private AudioSource audioSource;
    private BoxCollider2D boxCollider2D;
    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        //Step 2: Initalise variables
        audioSource = GetComponent<AudioSource>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        Debug.Log("Coin touched!");
        audioSource.Play();
        boxCollider2D.enabled = false;
        spriteRenderer.enabled = false;

        float length = audioSource.clip.length + 0.2f;

        Destroy(gameObject, length);
    }
}
