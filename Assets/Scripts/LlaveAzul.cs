using System.Collections;
using UnityEngine;

public class LlaveAzul : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            audioSource.Play();

            StartCoroutine(DestroyAfterSound());
        }
    }

    IEnumerator DestroyAfterSound()
    {
        GetComponent<Collider>().enabled = false;

        yield return new WaitWhile(() => audioSource.isPlaying);

        gameObject.SetActive(false);
    }
}
