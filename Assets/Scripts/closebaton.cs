using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closebaton : MonoBehaviour
{
    public GameObject nextb;
    public GameObject eye;
    public GameObject home;
    public GameObject close;
    // Update is called once per frame
    public void clic()
    {
        home.SetActive(true);
        nextb.SetActive(false);
        eye.SetActive(true);
        close.SetActive(false);
    }
}
