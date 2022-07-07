using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueShootingMethod : MonoBehaviour
{
    [SerializeField]
    private Transform SpawnPos;
    [SerializeField]
    private GameObject LaserShotPosition3;
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
        Instantiate(LaserShotPosition3, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
