using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class congratstrigger : MonoBehaviour
{
    public GameObject cube;
    public GameObject congrats;
    public GameObject lifecounter;
    public GameObject keyscore;
    public ParticleSystem particle1;
    public AudioClip ParticleSound1;
    bool shit = true;

    void Start()
    {
        congrats.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && shit)
        {
            congrats.SetActive(true);
            lifecounter.SetActive(false);
            keyscore.SetActive(false);
            particle1.Play();
            AudioSource.PlayClipAtPoint(ParticleSound1, transform.position, 1);
            shit = false;
        }
    }
}
