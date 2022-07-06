using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRed : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject RedVir;
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
        Instantiate(RedVir, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
