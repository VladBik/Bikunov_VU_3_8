using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBullet : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;
    [SerializeField]
    private Transform target;


    private void Update()
    {
        TargetBulletRed();
        DeathBullet();
    }

    private void TargetBulletRed()
    {
        target = GameObject.FindWithTag("VirusRed").transform;
        transform.LookAt(target.transform);
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
    }

    public void DeathBullet()
    {
        Destroy(gameObject, 5.1F);
    }

}
