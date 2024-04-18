using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placa2 : MonoBehaviour
{

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }

        
        GameObject caja = GameObject.Find("Caja");
        if (caja != null)
        {
            Rigidbody rb = caja.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.useGravity = true;
            }
        }
    }
}
