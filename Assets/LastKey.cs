using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastKey : MonoBehaviour
{
    [SerializeField]
    public GameObject lastkey;
    public AudioSource keypickup;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(lastkey);
            SceneManager.LoadScene(3);
            keypickup.Play();
        }
    }
}
