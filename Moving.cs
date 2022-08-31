using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Moving : MonoBehaviour
{
    public float jump_max = 0, step = 0.05f, jump = 0.06f, fall = 0.1962f, predel = 4.8f;
    public bool IsJumping = true, IsFalling, Isfall = true;
    public GameObject Back, cake, gold;
    private void Koving()
    {

        transform.position = transform.position + new Vector3(step, 0, 0);
        if (Input.GetKey(KeyCode.Space) && !Isfall)
        {
            if (IsJumping)
            {
                transform.position = transform.position + new Vector3(0, jump, 0);
                jump_max += jump;
                if (jump_max >= predel)
                {
                    IsJumping = false;
                    IsFalling = true;
                }

            }
            if (IsFalling)
            {
                transform.position = transform.position + new Vector3(0, -jump, 0);
                jump_max -= jump;
                if (jump_max <= 0.0f)
                {
                    IsJumping = true;
                    IsFalling = false;
                }
            }
        }
        else
        {
            Isfall = true;
            if (jump_max <= 0.0f)
            {
                Isfall = false;
            }
            else
            {
                transform.position = transform.position + new Vector3(0, -jump, 0);
                jump_max -= jump;
            }
        }
    }

    [SerializeField] Text HighScoreText;
    public int score;
    public Text text,text_1;

    public void AddCoid(int count)
    {
        score += count;
        text.text = score.ToString();
        text_1.text = score.ToString();

    }

    public int k = 0;
    public GameObject v_1, v_2, v_3, v_4, v_5, v_6, v_7;
    GameObject[] sp, v;
    GameObject[] spis, spisokCake, col_gold;
    private void BackGroung()
    {

        float pos = transform.position.x;
        spis = new GameObject[10000];
        spisokCake = new GameObject[40000];
        col_gold = new GameObject[10000];
        int x = (Convert.ToInt32(pos) / 38);
        if ( x == k)
        {
            k++;
            spis[k] = Instantiate( Back, new Vector3( x * 38 + 38, 2, 0), Quaternion.identity);
            //Debug.Log(x);
            int d = UnityEngine.Random.Range(2, 7), c = UnityEngine.Random.Range(0, 2), s = UnityEngine.Random.Range(0, 4);
            for (int i = 0; i < d; i++)
            {
                spisokCake[i] = Instantiate(cake, new Vector3( ( i * (38/d)) + k * 38 + UnityEngine.Random.Range(0f, 38/d-1), UnityEngine.Random.Range(1.62f, 4.15f), -1), Quaternion.identity);
            }
            for (int i = 0; i < c; i++)
            {
                spisokCake[i] = Instantiate(gold, new Vector3( ( i * (38/c) ) + k * 38 + UnityEngine.Random.Range(0f, 38/c), UnityEngine.Random.Range(1.62f, 4.15f), -1), Quaternion.identity);
            }
            v = new GameObject[7] { v_1, v_2, v_3, v_4, v_5, v_6, v_7 };
            for (int i = 0; i < s; i++)
            {
                spisokCake[i] = Instantiate(v[UnityEngine.Random.Range(0, 6)], new Vector3( (i * (38/s)) + k * 38 + UnityEngine.Random.Range(0f, 38/s-5), -1.7f, -1), Quaternion.identity);
            }
        }
    }
    int highscore;
    void Update()
    {
        Koving();
        BackGroung();
        if (PlayerPrefs.GetInt("text_1") <= score)
            PlayerPrefs.SetInt("text_1", score);

        HighScoreText.text = PlayerPrefs.GetInt("text_1").ToString();
    }
}