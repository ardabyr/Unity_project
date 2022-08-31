using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform luntik_sdvig;

    void Start()
    {
        luntik_sdvig = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        transform.position = new Vector3(luntik_sdvig.position.x+2, 0.5f, transform.position.z);
    }
}
