using UnityEngine;

public class Placa : MonoBehaviour
{
    private AudioSource audioSource;
    public float distanciaMovimiento = 5f; // Cantidad de unidades que la puerta se moverá hacia la derecha

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }

       
        if (collision.gameObject.name == "Caja")
        {
            GameObject puerta = GameObject.Find("Puerta");
            if (puerta != null)
            {
                puerta.transform.Translate(Vector3.back * distanciaMovimiento);
            }
        }
    }
}
