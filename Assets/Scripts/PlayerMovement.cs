using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;
    public float m_Speed = 5f;

    public Joystick joystick;


    public GameObject boo;

    private void Start()
    {
        
        

        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        Vector3 m_Input = new Vector3(joystick.Horizontal, 0, joystick.Vertical).normalized;

        

        rb.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);

        if(m_Input != Vector3.zero)
        {
            //transform.forward = m_Input;
            transform.rotation = Quaternion.LookRotation(m_Input);
        }
    }


    






}
