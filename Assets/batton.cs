using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class batton : MonoBehaviour
{
    public GameObject gm;
    public bool www = true;

    public void aaa ()
    {
        if (www == true)
        {
            gm.SetActive(false);
            www = false;
        }
        else
        {
            gm.SetActive(true);
            www = true;
        }
    }
}
