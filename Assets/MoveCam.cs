using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    private Vector3 m_camRot;
    private Transform m_camTransform; 
    private Transform m_transform; 
    public float m_movSpeed = 10; 
    public float m_rotateSpeed = 1;
    private void Start()
    {
        m_camTransform = Camera.main.transform;
        m_transform = GetComponent<Transform>();
    }
    private void Update()
    {
        Control();
    }
    void Control()
    {
        if (Input.GetMouseButton(0))
        {
            
            float rh = Input.GetAxis("Mouse X");
            float rv = Input.GetAxis("Mouse Y");

          
            m_camRot.x -= rv * m_rotateSpeed;
            m_camRot.y += rh * m_rotateSpeed;

     }

        //m_camTransform.eulerAngles = m_camRot;

       
       // Vector3 camrot = m_camTransform.eulerAngles;
       // camrot.x = 0; camrot.z = 0;
       // m_transform.eulerAngles = camrot;

       
        float xm = 0, ym = 0, zm = 0;

        
        if (Input.GetKey(KeyCode.W))
        {
            zm += m_movSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S)) 
        {
            zm -= m_movSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            xm -= m_movSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D)) 
        {
            xm += m_movSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space) && m_transform.position.y <= 3)
        {
            ym += m_movSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.F) && m_transform.position.y >= 1)
        {
            ym -= m_movSpeed * Time.deltaTime;
        }
        m_transform.Translate(new Vector3(xm, ym, zm), Space.Self);
    }

}
