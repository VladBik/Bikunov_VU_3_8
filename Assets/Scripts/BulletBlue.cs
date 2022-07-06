using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBlue : MonoBehaviour
{
    public float speed = 5;
    private Transform target;
    //public float seeDistance = 120f;
   // public float attackDistance = 122f;


    private void Start()
    {
       target = GameObject.FindGameObjectWithTag("VirusGreen").GetComponent<Transform>();
        
        Destroy(gameObject, 5.1F);
    }


    private void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.transform);
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

    }
    //void Update()
   // {
       // Fly1();
    //}

   // public void Fly1()
   // {
       // transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime;
        //speed = 10;
    //}
}
