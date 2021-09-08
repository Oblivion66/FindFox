using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class trigerpoint : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform t202;

    void OnTriggerEnter(Collider other)
    {
        agent.SetDestination(t202.position);
    }
}
