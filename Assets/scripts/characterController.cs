using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterController : MonoBehaviour
{
    public float movementForce = 15;

    public Text wintext;

    private Rigidbody rb;

    public int maxHealth = 100;
    public int currentHealth = 100;

    public Slider healthbar;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentHealth = maxHealth;
        healthbar.maxValue = maxHealth;
        healthbar.value = maxHealth;

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            TakeDamage(10);
        }
        if (other.CompareTag("runner"))
        {
            TakeDamage(10);
        }
        if (other.CompareTag("goal"))
        {
            this.gameObject.SetActive(false);
            wintext.text = "Mission Complete";
        }
        if (other.CompareTag("ebullet"))
        {
            TakeDamage(5);
        }
    }

    void FixedUpdate()
    {
        float xmov = Input.GetAxis("Horizontal");
        float zmov = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(xmov, 0, zmov);
        rb.velocity = new Vector3(xmov * movementForce, rb.velocity.y, zmov * movementForce);

        if (rb.velocity.x > 12f)
        {
            rb.velocity = new Vector3(12f, rb.velocity.y, rb.velocity.z);
        }
        if (rb.velocity.x < -12f)
        {
            rb.velocity = new Vector3(-12f, rb.velocity.y, rb.velocity.z);
        }
        if (rb.velocity.z > 7.5f)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 7.5f);
        }
        if (rb.velocity.z < -7.5f)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -7.5f);
        }

        if (currentHealth <= 0)
        {
            this.gameObject.SetActive(false);
            wintext.text = "Game Over";
        }

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.value = currentHealth;
    }
}
