using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAppear : MonoBehaviour
{

    public bool MenuShowed = false;
    public float speed = 1000f;
    public RectTransform rectTransform;
    public GameObject sh;

    public void Start() {
        rectTransform = GetComponent<RectTransform>();
    }

    public void Update() {
        if (MenuShowed) {
            float left = rectTransform.offsetMin.x + Time.deltaTime * speed;
            float right = rectTransform.offsetMax.x + Time.deltaTime * speed;
            left =  Mathf.Clamp(left, -160, 0);
            right =  Mathf.Clamp(right, -220, -60);

            rectTransform.offsetMin = new Vector2(left, 0);
            rectTransform.offsetMax = new Vector2 (right,0);
        } else {

            float left = rectTransform.offsetMin.x - Time.deltaTime * speed;
            float right = rectTransform.offsetMax.x - Time.deltaTime * speed;
            left =  Mathf.Clamp(left, -160, 0);
            right =  Mathf.Clamp(right, -220, -60);

            rectTransform.offsetMin = new Vector2(left, 0);
            rectTransform.offsetMax = new Vector2(right,0);
        }
    }

    public void show()
    {
        MenuShowed = true;
        sh.SetActive(true);
    }

    public void down() {
        MenuShowed = false;
        sh.SetActive(false);
    }

}
