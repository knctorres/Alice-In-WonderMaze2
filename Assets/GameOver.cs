using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public AudioSource gameover;

    public void ButtonStart()
    {
        KeyScoring.numberKeys = 0;
        SceneManager.LoadScene(1);
        gameover.Play();
    }
    public void ButtonQuit()
    {
        Application.Quit();
    }
}
