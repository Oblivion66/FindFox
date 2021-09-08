using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class next : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform point_b;

    public void eror ()
    {
        agent.GetComponent<TrailRenderer>().autodestruct = true;
        agent.SetDestination(point_b.position);
    }
}
