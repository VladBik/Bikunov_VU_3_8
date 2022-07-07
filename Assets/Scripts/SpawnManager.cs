using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private Transform SpawnPosRed;
    [SerializeField]
    private GameObject RedCrips;
    [SerializeField]
    private float TimeSpawnRed;

    [SerializeField]
    private Transform SpawnPosGreen;
    [SerializeField]
    private GameObject GreenCrip;
    [SerializeField]
    private float TimeSpawnGreen;

    [SerializeField]
    private Transform SpawnPosBlue;
    [SerializeField]
    private GameObject BlueCrip;
    [SerializeField]
    private float TimeSpawnBlue;



    void Start()
    {
        StartCoroutine(SpawnCDRed());
        StartCoroutine(SpawnCDGreen());
        StartCoroutine(SpawnCDBlue());
    }

    void RepeatBlue()
    {
        StartCoroutine(SpawnCDBlue());
    }
    IEnumerator SpawnCDBlue()
    {
        yield return new WaitForSeconds(TimeSpawnBlue);
        Instantiate(BlueCrip, SpawnPosBlue.position, Quaternion.identity);
        RepeatBlue();
    }


    void RepeatGreen()
    {
        StartCoroutine(SpawnCDGreen());
    }
    IEnumerator SpawnCDGreen()
    {
        yield return new WaitForSeconds(TimeSpawnGreen);
        Instantiate(GreenCrip, SpawnPosGreen.position, Quaternion.identity);
        RepeatGreen();
    }

    void RepeatRed()
    {
        StartCoroutine(SpawnCDRed());
    }
    IEnumerator SpawnCDRed()
    {
        yield return new WaitForSeconds(TimeSpawnRed);
        Instantiate(RedCrips, SpawnPosRed.position, Quaternion.identity);
        RepeatRed();
    }
}
