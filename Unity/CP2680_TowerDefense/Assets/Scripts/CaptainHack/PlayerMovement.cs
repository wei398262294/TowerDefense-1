using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    

    public float speed = 1000.0f;
    public float rotationSpeed = 2.0f;
    float camRayLength = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = false;

    }

    // Update is called once per frame
    void Update()
    {
        Turning();

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = transform.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = -transform.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {   
            rb.velocity = transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = -transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = transform.forward * speed * Time.deltaTime;
        }

    }

    void Turning()
    {
        Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);

        RaycastHit floorHit;

        if (Physics.Raycast (camRay, out floorHit, camRayLength))
        {
            Vector3 playerToMouse = floorHit.point - transform.position;
            playerToMouse.y = 90f;

            Quaternion newRotation = Quaternion.LookRotation (playerToMouse);
            rb.MoveRotation (newRotation);
        }
    }
}

*/

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;

    Vector3 movement;
    Rigidbody playerRigidbody;
    int floorMask;
    public float camRayLength = 100f;

    void Awake()
    {
        floorMask = LayerMask.GetMask ("Floor");
        playerRigidbody = GetComponent<Rigidbody> ();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw ("Horizontal");
        float v = Input.GetAxisRaw ("Vertical");

        Move (h, v);
        Turning ();
       // Animating (h, v);
    }

    void Move (float h, float v)
    {
        movement.Set (h, 0f, v);
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition (transform.position + movement);
    }

    void Turning()
    {
        Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);

        RaycastHit floorHit;

        if (Physics.Raycast (camRay, out floorHit, camRayLength, floorMask))
        {
            Vector3 playerToMouse = floorHit.point - transform.position;
            playerToMouse.y = 0f;

            Quaternion newRotation = Quaternion.LookRotation (playerToMouse);
            playerRigidbody.MoveRotation (newRotation);
        }
    }

    /*
    void Animating(float h, float v)
    {
        bool walking = h != 0f || v != 0f;
        anim.SetBool ("IsWalking", walking);
    }
    */
}