using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot1 : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject LaserShot33;
    public float TimeSpawn;

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
        Instantiate(LaserShot33, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
