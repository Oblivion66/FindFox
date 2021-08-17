using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lauer : MonoBehaviour
{
    public GameObject offon;
    public GameObject agentq;

    void Update()
    {
        if (agentq.transform.position.y > 1.1111)
        {
            offon.SetActive(true);
            //Debug.Log(agentq.transform.position.x);
        }
        if (agentq.transform.position.y < 1 && agentq.transform.position.x > 0)
        {
            offon.SetActive(false);
            //Debug.Log(agentq.transform.position.x);
        }

    }
}
