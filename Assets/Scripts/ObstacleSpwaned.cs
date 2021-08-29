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

        //InvokeRepeating(nameof(Spawn), 1f, spawnRate);
        StartCoroutine(nameof(SpawnObstacle));
    }

    IEnumerator SpawnObstacle()
    {
        while(true)
        {
            Spawn();

            yield return new WaitForSeconds(spawnRate);
        }
    }
    private void Spawn()
    {
        int randObstacle = Random.Range(0, obstacle.Length);

        if(randObstacle == 2)
        {
            spawnPos = new Vector3(10f, 0.5f, 0);

            Invoke(nameof(TimeRate), 0.5f);
        }

        Instantiate(obstacle[randObstacle], spawnPos, transform.rotation);
    }

    private void TimeRate()
    {
        spawnPos = transform.position;
    }
}
