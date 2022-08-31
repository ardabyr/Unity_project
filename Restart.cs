using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void Restart_1()
    {
        SceneManager.LoadScene(0);
    }
    public void Start()
    {
        Time.timeScale = 1;
    }
}
