using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefabs;

    private float upperRangeX = 80;
    private float upperRangeZ = 70;
    private float lowerRangeZ = -70;

    // Start is called before the first frame update
    void Start()
    {
        // Invoking Enemies
        InvokeRepeating("SpawnEnemiesUpperSide", 3, 2.5f);
        InvokeRepeating("SpawnEnemiesLowerSide", 3, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemiesUpperSide()
    {

        // Spawning Random from X-Axis
        Vector3 spawnPos = new Vector3(Random.Range(-upperRangeX, upperRangeX), 0, upperRangeZ);

        // Creating Instant of Random Enemies
        Instantiate(enemyPrefabs, spawnPos, enemyPrefabs.transform.rotation);

    }

    void SpawnEnemiesLowerSide()
    {

        // Spawning Random from X-Axis
        Vector3 spawnPos = new Vector3(Random.Range(-upperRangeX, upperRangeX), 0, lowerRangeZ);


        // Creating Instant of Random Enemies
        Instantiate(enemyPrefabs, spawnPos, enemyPrefabs.transform.rotation);
        
    }
}
