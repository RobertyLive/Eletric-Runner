using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpwaned : MonoBehaviour
{
    [Header("Lista dos obstaculos")]
    public GameObject[] obstacle; //array dos obstacle

    [Header("Tempo para spwanar")]
    public float spawnRate; //tempo para spawnar
    public float time;

    [Header("Posicao para spwanar")]
    [SerializeField] private Vector3 spawnPos; //posicao top botton

    [Header("Desafio")]
    float timeChallenger;
    public Obstacle obstacleInstance;
    public PlayerController playerInstance;


    private void Awake()
    {
        Init();
    }

    private void Update()
    {
        timeChallenger = Time.time;
    }

    private void Init()
    {
        spawnPos = transform.position;
        //InvokeRepeating(nameof(Spawn), 1f, spawnRate);
        StartCoroutine(nameof(SpawnObstacle));
    }

    public IEnumerator SpawnObstacle()
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

        int random = Random.Range(0 , 2);

        spawnPos = transform.position;

        if(randObstacle == 2)
        {
            spawnPos = new Vector3(10f, 0.5f, 0);

            Invoke(nameof(TimeRate), time);
        }

        if(random < 1)
        {
            Instantiate(obstacle[randObstacle], spawnPos, transform.rotation);
        }
        else
        {
            if(randObstacle <= 1)
            {
                spawnPos.x += 2; 
            }
            else if(randObstacle == 2)
            {
                spawnPos.x += 3;
            }
            else
            {
                spawnPos.x += 5;
            }

            GameObject obj = Instantiate(obstacle[randObstacle], spawnPos, transform.rotation);
            obj.transform.eulerAngles = new Vector3(0, 0, 180);

            if(obj.GetComponent<Obstacle>().speedMove > 0)
            {
                obj.GetComponent<Obstacle>().speedMove *= -1f;
            }
            else
            {
                obj.GetComponent<Obstacle>().speedMove *= 1f;
            }
        }

        Challenger();

    }
    private void TimeRate()
    {
        spawnPos = transform.position;
    }

    private void Challenger()
    {
        //if(Time.time == 10f)
        //{
        //    obstacle[Random.Range(0, obstacle.Length)].GetComponent<Obstacle>().speedMove = 15f;
        //}
        //else if(Time.time > 20f)
        //{
        //     obstacle[Random.Range(0, obstacle.Length)].GetComponent<Obstacle>().speedMove = 25f;
        //}

        switch (timeChallenger)
        {
            case 10f:
                obstacleInstance.speedMove = 10f;
                break;
            case 20f:
                obstacleInstance.speedMove = 20f;
                break;
            default:
                obstacleInstance.speedMove = timeChallenger;
                break;
        }
    }

    public void StopCorotine()
    {
        StopCoroutine(nameof(SpawnObstacle));
    }
}
