using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public bool isOn;

    private void Start()
    {
        isOn = true;
    }

    public void OnOffSounds()
    {
        if (!isOn)
        {
            AudioListener.volume = 0.5f;
            isOn = true;
        }
        else if (isOn)
        {
            AudioListener.volume = 0f;
            isOn = false;
        }
    }
}

