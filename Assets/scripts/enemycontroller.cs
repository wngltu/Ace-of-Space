using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, 0, -7.5f);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pbullet"))
        {
            Destroy(gameObject);
        }
    }
}
