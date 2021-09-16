using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eye_batton : MonoBehaviour
{
    public GameObject number4;
    public GameObject number3;
    public GameObject number2;
    public GameObject item4;
    public GameObject item3;
    public GameObject item2;
    public bool tf = true;

    public void offon()
    {
        if (tf == true)
        {
            number4.SetActive(false);
            number3.SetActive(false);
            number2.SetActive(false);
            item4.SetActive(true);
            item3.SetActive(true);
            item2.SetActive(true);
            tf = false;
        }
        else
        {
            number4.SetActive(true);
            number3.SetActive(true);
            number2.SetActive(true);
            item4.SetActive(false);
            item3.SetActive(false);
            item2.SetActive(false);
            tf = true;
        }
    }
}
