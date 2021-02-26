using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyScoring : MonoBehaviour
{
    public TextMeshProUGUI numkeys;
    public static int numberKeys;
    public AudioSource keypickup;

    void Update()
    {
        numkeys.GetComponent<TextMeshProUGUI>().text = ": " + numberKeys;
    }

    void OnTriggerEnter(Collider other)
    {
        numberKeys += 1;
        Destroy(gameObject);
        keypickup.Play();
    }

}
