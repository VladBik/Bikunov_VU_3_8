using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    public float Speed = 10f;
    public float JumpForce = 10f;

   
    //private bool _isGrounded;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        MovementLogic();
        //JumpLogic();
    }

    private void MovementLogic()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        _rb.AddForce(movement * Speed);
    }

    //private void JumpLogic()
   // {
        //if (Input.GetAxis("Jump") > 0)
       // {
           // if (_isGrounded)
           // {
               // _rb.AddForce(Vector3.up * JumpForce);
         //}
        //}
   // }

    //void OnCollisionEnter(Collision collision)
    //{
       // IsGroundedUpate(collision, true);
    //}

   // void OnCollisionExit(Collision collision)
    //{
       // IsGroundedUpate(collision, false);
   // }

    //private void IsGroundedUpate(Collision collision, bool value)
   // {
        //if (collision.gameObject.tag == ("Ground"))
       // {
           // _isGrounded = value;
       // }
    //}
}
