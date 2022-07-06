using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRed : MonoBehaviour
{
    public float speed = 5;
    private Transform target;



    private void Start()
    {
        target = GameObject.FindWithTag("VirusRed").transform;
        //target = GameObject.FindGameObjectWithTag("VirusBlue").GetComponent<Transform>();
        Destroy(gameObject, 5.1F);
    }


    private void Update()
    {
        
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
