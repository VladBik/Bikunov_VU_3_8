using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingHelper : MonoBehaviour
{
    [SerializeField]
    private Transform SpawnPos;
    [SerializeField]
    private GameObject LaserShot13;
    [SerializeField]
    private float TimeSpawn;

    void Uodate()
    {
        Repeat();
    }

    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(LaserShot13, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
