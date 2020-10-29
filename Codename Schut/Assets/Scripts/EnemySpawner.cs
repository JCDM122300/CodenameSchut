using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private float spawnRangeX = 16.5f;
    private float spawnPosZ = 20;
    private float spawnPosY = 3.25f;
    private float StartDelay = 2;
    private float SpawnInterval = 1.5f;
    public GameObject[] EnemyPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", StartDelay, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void SpawnRandomEnemy()
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, spawnPosZ);
            int EnemyIndex = Random.Range(0, EnemyPrefabs.Length);
            Instantiate(EnemyPrefabs[EnemyIndex], spawnPos, EnemyPrefabs[EnemyIndex].transform.rotation);
        }
}
