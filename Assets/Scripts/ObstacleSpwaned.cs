using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpwaned : MonoBehaviour
{
    public GameObject[] obstacle;
    public float spawnRate;
    [SerializeField] private Vector3 spawnPos;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        spawnPos = transform.position;

        InvokeRepeating(nameof(Spawn), 1f, spawnRate);
    }

    private void Spawn()
    {
        int randObstacle = Random.Range(0, obstacle.Length);

        Instantiate(obstacle[randObstacle], spawnPos, transform.rotation);
    }
}
