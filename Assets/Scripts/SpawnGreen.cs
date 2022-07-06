using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGreen : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject GreenVir;
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
        Instantiate(GreenVir, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
