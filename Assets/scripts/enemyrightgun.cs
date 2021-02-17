using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyrightgun : MonoBehaviour
{
    GameObject clone;
    public GameObject ebullet;
    float cooldown = 1.25f;
    float cooldowntimer = 1.25f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cooldowntimer += Time.deltaTime;

        if (cooldowntimer > cooldown)
        {
            clone = (GameObject)Instantiate(ebullet, transform.position, Quaternion.identity);
            clone.GetComponent<Rigidbody>().velocity = new Vector3(10, 0, -20);
            cooldowntimer = 0;
        }
    }
}
