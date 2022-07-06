using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlue : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject BlueVir;
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
        Instantiate(BlueVir, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
