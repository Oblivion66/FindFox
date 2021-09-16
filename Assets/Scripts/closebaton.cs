using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closebaton : MonoBehaviour
{
    public GameObject nextb;
    public GameObject eye;
    public GameObject close;
    public TrailRenderer aggent;
    public GameObject floor;

    // Update is called once per frame
    public void clic()
    {
        floor.SetActive(true);
        aggent.Clear();
        nextb.SetActive(false);
        eye.SetActive(true);
        close.SetActive(false);
    }
}
