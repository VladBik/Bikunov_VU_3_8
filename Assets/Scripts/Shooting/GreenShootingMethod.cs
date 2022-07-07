using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenShootingMethod : MonoBehaviour
{
    [SerializeField]
    private Transform SpawnPos;
    [SerializeField]
    private GameObject LaserShotPosition1;
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
        Instantiate(LaserShotPosition1, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
