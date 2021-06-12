using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScreen : MonoBehaviour
{

    public GameObject search;
    public GameObject menu;
    public GameObject QR;
    public GameObject close;
    public GameObject open;
    public static bool isOpen = false;
    public float speed = 350f;
    public RectTransform rtSearch;
    public RectTransform rtMenu;
    public RectTransform rtQR;

    void Update()
    {
        if (isOpen)
        {
            float botton = rtMenu.offsetMin.y + Time.deltaTime * speed;
            float top = rtMenu.offsetMax.y + Time.deltaTime * speed;
            top = Mathf.Clamp(top, -30, 40);
            botton = Mathf.Clamp(botton, -50, 20);

            rtMenu.offsetMin = new Vector2(rtMenu.offsetMin.x, botton);
            rtMenu.offsetMax = new Vector2(rtMenu.offsetMax.x, top);

            botton = rtSearch.offsetMin.y + Time.deltaTime * speed;
            top = rtSearch.offsetMax.y + Time.deltaTime * speed;
            top = Mathf.Clamp(top, -26.5f, 36.5f);
            botton = Mathf.Clamp(botton, -50f, 20f);

            rtSearch.offsetMin = new Vector2(rtSearch.offsetMin.x, botton);
            rtSearch.offsetMax = new Vector2(rtSearch.offsetMax.x, top);

            botton = rtQR.offsetMin.y - Time.deltaTime * speed;
            top = rtQR.offsetMax.y - Time.deltaTime * speed;
            top = Mathf.Clamp(top, -5f, 105f);
            botton = Mathf.Clamp(botton, -155f, -45f);

            rtQR.offsetMin = new Vector2(rtQR.offsetMin.x, botton);
            rtQR.offsetMax = new Vector2(rtQR.offsetMax.x, top);

        } else
        {  
            float botton = rtMenu.offsetMin.y - Time.deltaTime * speed;
            float top = rtMenu.offsetMax.y - Time.deltaTime * speed;
            top = Mathf.Clamp(top, -30f, 40f);
            botton = Mathf.Clamp(botton, -50f, 20f);

            rtMenu.offsetMin = new Vector2(rtMenu.offsetMin.x, botton);
            rtMenu.offsetMax = new Vector2(rtMenu.offsetMax.x, top);

            botton = rtSearch.offsetMin.y - Time.deltaTime * speed;
            top = rtSearch.offsetMax.y - Time.deltaTime * speed;
            top = Mathf.Clamp(top, -25f, 45f);
            botton = Mathf.Clamp(botton, -50f, 20f);

            rtSearch.offsetMin = new Vector2(rtSearch.offsetMin.x, botton);
            rtSearch.offsetMax = new Vector2(rtSearch.offsetMax.x, top);

            botton = rtQR.offsetMin.y + Time.deltaTime * speed;
            top = rtQR.offsetMax.y + Time.deltaTime * speed;
            top = Mathf.Clamp(top, -5f, 105f);
            botton = Mathf.Clamp(botton, -155f, -45f);

            rtQR.offsetMin = new Vector2(rtQR.offsetMin.x, botton);
            rtQR.offsetMax = new Vector2(rtQR.offsetMax.x, top);

        }

    }

    public void Open()
    {
        
        if (isOpen)
        {
            open.SetActive(true);
            close.SetActive(false);
        } else
        {
            open.SetActive(false);
            close.SetActive(true);
        }

        isOpen = !isOpen; 
    }

}
