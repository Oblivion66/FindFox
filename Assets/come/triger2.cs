using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triger2 : MonoBehaviour
{
    public GameObject gm;
    public GameObject agentq;

    void OnTriggerExit(Collider other)
    {
        //gm.SetActive(false);
        if (other.tag == "Player")
        {
            if (agentq.transform.position.y < 0.3)
            {
                gm.SetActive(true);
                //Debug.Log(agentq.transform.position.x);
            }
            if (agentq.transform.position.y > 0.3)
            {
                gm.SetActive(false);
                //Debug.Log(agentq.transform.position.x);
            }
        }
    }
}
