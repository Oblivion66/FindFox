using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class batton_floor : MonoBehaviour
{
    public GameObject floor;
    public bool tf = true;

    public void offon ()
    {
        if (tf == true)
        {
            floor.SetActive(false);
            tf = false;
        }
        else
        {
            floor.SetActive(true);
            tf = true;
        }
    }
}
