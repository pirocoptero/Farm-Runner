using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstaclePrefab;
    private PlayerController playerControllerScript;
    Vector3 spawnPosition = new Vector3(25, 0.5f, 0);
    float startDelay = 2;
    float repeatRate = 2;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {

            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
        }
    }

}
