using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class PlayerControl : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform t201;
    [SerializeField] Transform t202;
    [SerializeField] Transform t301;
    [SerializeField] Transform t302;
    [SerializeField] Transform t303;
    [SerializeField] Transform t304;
    [SerializeField] Transform t305;
    [SerializeField] Transform t306;
    [SerializeField] Transform t307;
    [SerializeField] Transform t308;
    [SerializeField] Transform t309;
    [SerializeField] Transform t310;
    [SerializeField] Transform t401;
    [SerializeField] Transform t402;
    [SerializeField] Transform t403;
    [SerializeField] Transform t404;
    [SerializeField] Transform t405;
    [SerializeField] Transform t406;
    [SerializeField] Transform t407;
    [SerializeField] Transform toalet1;
    [SerializeField] Transform toalet2;

    void Start()
    {
        string a = "0";
        a = "201";
        switch (a)
        {
            case "201":
                agent.SetDestination(t201.position);
                break;
            case "202":
                agent.SetDestination(t202.position);
                break;
            case "301":
                agent.SetDestination(t301.position);
                break;
            case "302":
                agent.SetDestination(t302.position);
                break;
            case "303":
                agent.SetDestination(t303.position);
                break;
            case "304":
                agent.SetDestination(t304.position);
                break;
            case "305":
                agent.SetDestination(t305.position);
                break;
            case "306":
                agent.SetDestination(t306.position);
                break;
            case "307":
                agent.SetDestination(t307.position);
                break;
            case "308":
                agent.SetDestination(t308.position);
                break;
            case "309":
                agent.SetDestination(t309.position);
                break;
            case "310":
                agent.SetDestination(t310.position);
                break;
            case "toalet":
                agent.SetDestination(toalet1.position);
                break;

        }
    }
}
