using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triger : MonoBehaviour
{
    public GameObject gm;
    public GameObject agentq;

    void OnTriggerExit (Collider other)
    {
        //gm.SetActive(false);
        if (other.tag == "Player") 
        {
            if (agentq.transform.position.y > 1.2)
            {
                gm.SetActive(true);
                //Debug.Log(agentq.transform.position.x);
            }
            if (agentq.transform.position.y < 1.2)
            {
                gm.SetActive(false);
                //Debug.Log(agentq.transform.position.x);
            }
        }
    }
}