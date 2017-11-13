using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJumpItem : MonoBehaviour {

    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;
    private PlayerController playerController;

	void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerController = FindObjectOfType<PlayerController>();
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Coin touched!");
        audioSource.Play();
        playerController.DoubleJumpItem = true;
        spriteRenderer.enabled = false;
        boxCollider2D.enabled = false;
    }
}
