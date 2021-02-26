using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTrigger : MonoBehaviour
{
    [SerializeField]
    public GameObject Door;
    public ParticleSystem particle;
    public GameObject key;
    public AudioClip ParticleSound;
    public AudioSource keypickup;
    bool shitka = true;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")&& shitka)
        {
            Destroy(key);
            Destroy(Door, 0.75f);
            particle.Play();
            AudioSource.PlayClipAtPoint(ParticleSound, transform.position, 1);
            shitka = false;
            keypickup.Play();
        }
    }
}
