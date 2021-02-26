using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeysLifeDisplay : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject key;
    public GameObject score;

    void Start()
    {
        heart1.SetActive(false);
        heart2.SetActive(false);
        heart3.SetActive(false);
        key.SetActive(false);
        score.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
            key.SetActive(true);
            score.SetActive(true);
        }
    }

}
