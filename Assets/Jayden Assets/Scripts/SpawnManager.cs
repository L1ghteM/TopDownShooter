using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;

    public float spawnRate;
    public float maxXpos;
    public float maxYpos;
    // Start is called before the first frame update
    void Start()
    {
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Spawn()
    {
        float randomX = Random.Range(-maxXpos, maxXpos);
        float randomY = Random.Range(-maxYpos, maxYpos);
        Vector2 spawnPos = new Vector2(randomX,randomY);
        Instantiate(enemy, spawnPos, Quaternion.identity);
    }
    void StartSpawning()
    {
        InvokeRepeating("Spawn", 1f, spawnRate);
    }
    public void StopSpawning()
    {
        CancelInvoke("Spawn");
    }
}
