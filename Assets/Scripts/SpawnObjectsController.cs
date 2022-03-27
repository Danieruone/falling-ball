using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectsController : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("LaunchObstacle", 2.0f, 3.0f);
    }

    void LaunchObstacle()
    {
        int randomNumber = Random.Range(0, 2);
        Instantiate(obstacle, spawnPoints[randomNumber].position, spawnPoints[randomNumber].rotation);
    }
}
