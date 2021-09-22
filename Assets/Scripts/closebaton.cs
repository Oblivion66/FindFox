using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class closebaton : MonoBehaviour
{
    public GameObject nextb;
    public GameObject close;
    public TrailRenderer agenttrail;
    public NavMeshAgent agent;
    public GameObject floor;
    public Transform QRP1;
    public GameObject aggent;

    public void clic()
    {
        agent.enabled = false;
        aggent.transform.position = QRP1.position;
        agent.enabled = true;
        agenttrail.Clear();

        floor.SetActive(true);
        nextb.SetActive(false);
        close.SetActive(false);
    }
}
