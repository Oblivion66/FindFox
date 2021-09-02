using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QRCode : MonoBehaviour
{
    public Sprite sprite;
    public Image img;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        sprite = img.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
