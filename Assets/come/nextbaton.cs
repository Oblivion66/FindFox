using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextbaton : MonoBehaviour
{
    [SerializeField] Text text;
    public GameObject nextb;
    public GameObject eye;
    public static string pointB;

    void Update()
    {
        pointB = text.text.ToString();
        if (pointB != "")
        {
            nextb.SetActive(true);
            eye.SetActive(false);
        }
        else
        {
            nextb.SetActive(false);
            eye.SetActive(true);
        }
    }
}
