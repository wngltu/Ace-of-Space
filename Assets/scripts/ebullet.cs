using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ebullet : MonoBehaviour
{
    void Awake()
    {
        Destroy(gameObject, 1.0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
