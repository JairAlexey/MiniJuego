using System.Collections;
using UnityEngine;

public class LlaveRoja : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "CuboRojo")
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
