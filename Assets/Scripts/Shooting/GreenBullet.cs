using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBullet : MonoBehaviour
{
    [SerializeField]
   private float speed = 5;
    [SerializeField]
    private Transform target;


    private void Update()
    {
        TargetBulletGreen();
        DeathBullet();

        //transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    private void TargetBulletGreen()
    {
        target = GameObject.FindGameObjectWithTag("VirusRed").GetComponent<Transform>();
        transform.LookAt(target.transform);
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
    }

    public void DeathBullet()
    {
        Destroy(gameObject, 5.1F);
    }
}
