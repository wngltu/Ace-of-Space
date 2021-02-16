using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float movementForce = 10;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float xmov = Input.GetAxis("Horizontal");
        float ymov = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(xmov, ymov, 0);
        rb.velocity = new Vector3(xmov * movementForce, ymov * movementForce, rb.velocity.z);

        if (rb.velocity.x > 12f)
        {
            rb.velocity = new Vector3(12f, rb.velocity.y, rb.velocity.z);
        }
        if (rb.velocity.x < -12f)
        {
            rb.velocity = new Vector3(-12f, rb.velocity.y, rb.velocity.z);
        }
        if (rb.velocity.y > 7.5f)
        {
            rb.velocity = new Vector3(rb.velocity.x, 7.5f, rb.velocity.z);
        }
        if (rb.velocity.y < -7.5f)
        {
            rb.velocity = new Vector3(rb.velocity.x, -7.5f, rb.velocity.z);
        }

    }
}
