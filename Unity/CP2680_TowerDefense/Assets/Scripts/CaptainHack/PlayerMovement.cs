using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = transform.up * speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = -transform.up * speed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {   
            rb.velocity = transform.right * speed;
//            transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
//            transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = -transform.right * speed;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = transform.forward * speed;
        }

    }
}