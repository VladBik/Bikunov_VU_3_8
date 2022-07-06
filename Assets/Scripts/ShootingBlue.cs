using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBlue : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;
    [SerializeField]
    private Transform target;
    
    private void Update()
    {
        
        TargetBulletBlue();
        DeathBullet();

    }
    
    private void TargetBulletBlue()
    {
        target = GameObject.FindGameObjectWithTag("VirusGreen").GetComponent<Transform>();
        transform.LookAt(target.transform);
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
    }

    public void DeathBullet()
    {
        Debug.Log("синяя пуля просвистела мимо");
        Destroy(gameObject, 5.1F);
    }
}
