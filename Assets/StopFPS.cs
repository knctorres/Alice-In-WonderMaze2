using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopFPS : MonoBehaviour
{
    public GameObject Canvas;
    bool mema = true;

    void Update()
    {
        if (Canvas.activeSelf == false)
        {
            mema = false;
        }

        if (!mema)
        {
            Time.timeScale = 1;
        }
        else if (mema)
        {
            Time.timeScale = 0;
        }
    }

}
