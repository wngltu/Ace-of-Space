using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyrespawner : MonoBehaviour
{
        public GameObject runner;
    GameObject clone;

    float respawn = 1.25f;
    float respawntimer = 1.25f;

    Vector3 randompos;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        respawntimer += Time.deltaTime;

        if (respawntimer >= respawn)
        {
            randompos = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(5f, 25f));
            clone = (GameObject)Instantiate(runner, randompos, Quaternion.identity);
            respawntimer = 0;
        }
    }
}
