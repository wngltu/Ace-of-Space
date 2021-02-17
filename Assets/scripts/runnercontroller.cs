using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class runnercontroller : MonoBehaviour
{
    public GameObject player;
    private NavMeshAgent agent;



    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = player.transform.position;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("phitbox") || other.gameObject.CompareTag("pbullet"))
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("bottomwall"))
        {
            Destroy(gameObject);
        }
    }
}
