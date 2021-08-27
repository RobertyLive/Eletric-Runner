using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float playerPosY;
    void Start()
    {
        playerPosY = transform.position.y;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            playerPosY = -playerPosY;

            transform.position = new Vector3(transform.position.x, playerPosY, transform.position.z);
        }
    }
}
