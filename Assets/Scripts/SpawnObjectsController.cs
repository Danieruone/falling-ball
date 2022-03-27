using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectsController : MonoBehaviour
{
    public Transform[] spawnPoints;
    public Transform[] spawnObstacles;

    public GameObject point;
    public GameObject obstacle;

    void Start()
    {
        InvokeRepeating("LaunchPoint", 1.0f, 1.0f);
        InvokeRepeating("LaunchObstacle", 2.0f, 3.0f);
    }

    void LaunchPoint()
    {
        int randomNumber = Random.Range(0, 3);
        Instantiate(point, spawnPoints[randomNumber].position, spawnPoints[randomNumber].rotation);
    }

    void LaunchObstacle()
    {
        int randomNumber = Random.Range(0, 2);
        Instantiate(obstacle, spawnObstacles[randomNumber].position, spawnObstacles[randomNumber].rotation);
    }
}
