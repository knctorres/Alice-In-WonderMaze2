using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message2 : MonoBehaviour
{
    public GameObject cube;
    public GameObject canvas2;
    bool shit = true;

    void Start()
    {
        canvas2.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && shit) 
        {
            canvas2.SetActive(true);
            shit = false;
        }
    }
}
