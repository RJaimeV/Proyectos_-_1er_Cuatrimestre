using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpawner : MonoBehaviour
{
    public int RoundCount = 5;
    public float timeBetweenRounds = 3;
    public int Spawnarea = 5;
    public List<GameObject> prefabs;

    [Header("Debug")]
    public float currentTime = 5;
    public int currentRounf = 0;

    public void Spawner()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= timeBetweenRounds)
        {
            ObjectGeneration();
            currentTime = 0f;
            currentRounf++;

        }

        if (currentRounf >= RoundCount)
        {
            currentRounf = 0;
            timeBetweenRounds += 0.9f;
        }

    }

    public void ObjectGeneration()
    {

        Vector3 SpawnPosition = new Vector3(Random.Range(-Spawnarea, Spawnarea), Random.Range(-Spawnarea, Spawnarea), 0);
        GameObject Randomobj = prefabs[Random.Range(0, prefabs.Count)];
        GameObject clone = Instantiate(Randomobj, SpawnPosition, Quaternion.identity);
        clone.transform.parent = transform;

    }

    void Update()
    {
        Spawner();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, new Vector3(-Spawnarea, Spawnarea, 0));
    }
}
