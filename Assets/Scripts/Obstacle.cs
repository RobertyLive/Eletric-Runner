using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speedMove;
    void Update()
    {
        transform.Translate(Vector3.left * speedMove * Time.deltaTime);

        if(transform.position.x < -10f)
        {
            Destroy(this.gameObject);
        }

    }
}
