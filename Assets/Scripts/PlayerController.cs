using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float playerPosY;
    public int life = 3;

    public ObstacleSpwaned obstacleSpwaned;

    void Start()
    {
        playerPosY = transform.position.y;
        GameManager.instance.txtLife.text = life.ToString();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            playerPosY = -playerPosY;

            transform.position = new Vector3(transform.position.x, playerPosY, transform.position.z);
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Obstacle")
        {
            life--;

            if (life < 1)
            {
                obstacleSpwaned.StopCorotine();
                GameManager.instance.ShowPainel(true);
                Destroy(this.gameObject);
            }

            GameManager.instance.txtLife.text = life.ToString();
        }
    }
}
