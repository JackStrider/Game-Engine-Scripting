using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour {

    private AudioSource audioSource;

    [SerializeField]
    int deathDelay;

    Animator anim;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        anim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioSource.Play();
            StartCoroutine(Death());         
        }
    }

    IEnumerator Death()
    {
        anim.SetTrigger("Death");
        yield return new WaitForSeconds(deathDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
