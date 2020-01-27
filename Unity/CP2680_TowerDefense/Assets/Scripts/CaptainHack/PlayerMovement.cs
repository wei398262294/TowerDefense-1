using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 2.0f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = false;

    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = transform.up * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = -transform.up * speed;
        }

        if (Input.GetKey(KeyCode.W))
        {   
            rb.velocity = transform.right * speed;
//            transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
//            transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);

        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = -transform.right * speed;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = transform.forward * speed;
        }

       
    }
}