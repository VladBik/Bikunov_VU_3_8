using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedShootingMethod : MonoBehaviour
{
    [SerializeField]
    private Transform SpawnPos;
    [SerializeField]
    private GameObject LaserShotPosition2;
    [SerializeField]
    private float TimeSpawn;

    void Start()
    {
        StartCoroutine(SpawnCD());
    }

    
    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(LaserShotPosition2, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
