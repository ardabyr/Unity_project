using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            var DiePanel = GameObject.Find("DiePanel").GetComponent<Transform>().GetChild(0);
            DiePanel.gameObject.SetActive(true);
            Time.timeScale = 0;
            collision.GetComponent<Moving>().step = 0;
        }
    }


}
