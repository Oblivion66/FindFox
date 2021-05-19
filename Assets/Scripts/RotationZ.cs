using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationZ : MonoBehaviour
{
    public GameObject model;
    public bool isDown = false;
    public float speed = 0.1f;
    public float direction = 1f;
    public float z = -15f;

    // Update is called once per frame
    void Update()
    {
        if (isDown)
        {

            if (direction == 1f && z < -15f)
            {
                model.transform.Rotate(0, 0, direction * speed);
                z += direction * speed;
            }
            if (direction == -1f && z > -80)
            {
                model.transform.Rotate(0, 0, direction * speed);
                z += direction * speed;
            }
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

    public void setDirectionDown()
    {
        direction = -1f;
        down();
    }
}
