using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class triger23 : MonoBehaviour
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
            if (agentq.transform.position.y > 0.4)
            {
                gm.SetActive(false);
                agent.SetDestination(QRP2.position);
            }
            if (agentq.transform.position.y < 0.2)
            {
                gm.SetActive(true);
                agent.SetDestination(QRP1.position);
            }
        }
    }
}
