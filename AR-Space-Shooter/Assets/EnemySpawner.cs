using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> spawnPoints;
    public GameObject enemyPrefab;
    float timer;
    int waitingTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > waitingTime){
            //Action
            Instantiate(enemyPrefab, spawnPoints[0].transform.position, spawnPoints[0].transform.rotation);
            Instantiate(enemyPrefab, spawnPoints[1].transform.position, spawnPoints[1].transform.rotation);
            Instantiate(enemyPrefab, spawnPoints[2].transform.position, spawnPoints[2].transform.rotation);
            timer = 0;
        }
    }
}
