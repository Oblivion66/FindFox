using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class triger : MonoBehaviour
{
    public GameObject gm;
    public GameObject agentq;
    [SerializeField] Transform QRP2;
    [SerializeField] Transform QRP1;
    [SerializeField] NavMeshAgent agent;

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player") 
        {
            if (agentq.transform.position.y > 1.3)
            {
                agent.SetDestination(QRP2.position);
                gm.SetActive(true);
            }
            if (agentq.transform.position.y < 1.2)
            {
                gm.SetActive(false);
                agent.SetDestination(QRP1.position);
            }
        }
    }
}