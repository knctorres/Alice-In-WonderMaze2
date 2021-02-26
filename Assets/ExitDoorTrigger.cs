using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoorTrigger : MonoBehaviour
{
    public GameObject ExitDoor;
    public GameObject exitdoortrigger;
    public GameObject barrier;
    public ParticleSystem FinalParticle;
    public AudioClip ParticleSFX;

    void Update()
    {
        if (KeyScoring.numberKeys == 3)
        {
            Destroy(barrier);
        }
        if (ExitDoor == null)
        {
            AudioSource.PlayClipAtPoint(ParticleSFX, transform.position, 1); 
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(ExitDoor);
            FinalParticle.Play();
        }
    }
}
