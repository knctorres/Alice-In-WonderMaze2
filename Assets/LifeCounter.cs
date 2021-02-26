using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeCounter : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;
    public AudioSource rHole;



    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            life -= 1;
            rHole.Play();
            
        }
    }


    void Update()
    {
        if (life == 0)
        {
            SceneManager.LoadScene(2);
        }
        else if (life == 1)
        {
            Destroy(hearts[1].gameObject);
        }
        else if (life == 2)
        {
            Destroy(hearts[2].gameObject);
        }

       
    }
}
