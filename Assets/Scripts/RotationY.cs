using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationY : MonoBehaviour
{

    public GameObject model;
    public bool isDown = false;
    public float speed = 0.1f;
    public float direction = 1f;
    public static float y = 90;

    // Update is called once per frame
    void Update()
    {
        if (isDown)
        {
            model.transform.Rotate(0, direction * speed, 0);
            y += direction * speed;
        }
    }

    public void down()
    {
        isDown = true;
}

    public void up()
    {
        isDown = false;
        direction = 1f;
    }

    public void setDirectionRight()
    {
        direction = -1f;
        down();
    }

}
