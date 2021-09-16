using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using System;

public class PlayerControl : MonoBehaviour
{
    public GameObject nextb;
    public GameObject eye;
    public GameObject close;

    public GameObject floor;

    public static string pointB;
    public static SimpleDemo value;
    public TrailRenderer aggent;
    public GameObject agggent;
    public NavMeshAgent aggggent;
    [SerializeField] Text t2;
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

    [SerializeField] Transform QRP1;
    [SerializeField] Transform QRP2;
    [SerializeField] Transform QRP3;
    [SerializeField] Transform QRP31;
    [SerializeField] Transform QRP32;
    [SerializeField] Transform QRP33;
    [SerializeField] Transform QRP41;
    [SerializeField] Transform QRP42;
    [SerializeField] Transform QRP43;

    public void findQR()
    {
        if (agggent.transform.position.y < 1.3)
        {
            floor.SetActive(false);
        }
        else
        {
            floor.SetActive(true);
        }
        nextb.SetActive(false);
        eye.SetActive(false);
        close.SetActive(true);

        aggggent = GetComponent<NavMeshAgent>();
        aggggent.enabled = false;
        switch (SimpleDemo.value)
        {
            case "1floor":
                agggent.transform.position = QRP1.position;
                break;
            case "2floor":
                agggent.transform.position = QRP2.position;
                break;
            case "3floor":
                agggent.transform.position = QRP3.position;
                break;
            case "3-1floor":
                agggent.transform.position = QRP31.position;
                break;
            case "3-2floor":
                agggent.transform.position = QRP32.position;
                break;
            case "3-3floor":
                agggent.transform.position = QRP33.position;
                break;
            case "4-1floor":
                agggent.transform.position = QRP41.position;
                break;
            case "4-2floor":
                agggent.transform.position = QRP42.position;
                break;
            case "4-3floor":
                agggent.transform.position = QRP43.position;
                break;
        }
        aggggent.enabled = true;
        aggent.Clear();

    }


    public void starfind()
    {
        eye.SetActive(false);
        close.SetActive(true);

        nextb.SetActive(true);
        aggent.Clear();
        pointB = t2.text.ToString();
        int pointBB = Convert.ToInt32(pointB);

        if (agggent.transform.position.y < 1.3 && pointBB < 400)
        {
            floor.SetActive(false);
        }
        else {
            floor.SetActive(true);
        }
        switch (pointB)
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
            case "401":
                agent.SetDestination(t401.position);
                break;
            case "402":
                agent.SetDestination(t402.position);
                break;
            case "403":
                agent.SetDestination(t403.position);
                break;
            case "404":
                agent.SetDestination(t404.position);
                break;
            case "405":
                agent.SetDestination(t405.position);
                break;
            case "406":
                agent.SetDestination(t406.position);
                break;
            case "407":
                agent.SetDestination(t407.position);
                break;
            case "туалет":
                agent.SetDestination(toalet1.position);
                break;

        }
    }
}
