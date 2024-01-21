using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimateSpawner : MonoBehaviour
{
    public GameObject ultimatePrefab;
    public float spawnInterval = 15f; // Time in seconds for the Ultimate to spawn
    public Vector2 spawnAreaMin; // Minimum spawn area
    public Vector2 spawnAreaMax; // Maximum spawn area

    void Start()
    {
        StartCoroutine(SpawnUltimateRoutine());
    }

    IEnumerator SpawnUltimateRoutine()
    {
        while (true)
        { // Infinite loop to continuously spawn Ultimates
            yield return new WaitForSeconds(spawnInterval); // Wait for the specified interval
            SpawnUltimate();
        }
    }

    void SpawnUltimate()
    {
        // Randomly choose a position within the specified bounds
        Vector2 spawnPosition = new Vector2(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            Random.Range(spawnAreaMin.y, spawnAreaMax.y)
        );
        Instantiate(ultimatePrefab, spawnPosition, Quaternion.identity);
    }
}