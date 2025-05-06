
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager: MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRange = 9.0f;
    public float spawnRangeZ = 35f;
    public int enemyCount;
    public int waveNumber = 1;
    private GameManager gameManager;
 

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
        gameManager = GameObject.Find ("GameManager").GetComponent<GameManager>();
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
                Instantiate(enemyPrefab, EnemySpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {
        

        while (gameManager.isGameActive)
        {
            enemyCount = FindObjectsOfType<Enemy>().Length;
            
            if(enemyCount == 0)
            {
                waveNumber++;
                SpawnEnemyWave(waveNumber);
         
            }
        }
    }

    private Vector3 EnemySpawnPosition ()
    {
        float spawnPositionX = Random.Range(-spawnRange, spawnRange);
        float spawnPositionZ = Random.Range(5, 100);
        float spawnPositionY = Random.Range(0, 5);

        Vector3 spawnPos = new Vector3(spawnPositionX, spawnPositionY, spawnPositionZ);

        return spawnPos;
    }
}
