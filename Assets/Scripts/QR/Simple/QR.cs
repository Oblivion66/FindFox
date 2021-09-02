using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QR : MonoBehaviour
{
    public SimpleDemo scan;
    public string QRvalue;
    public bool state = false;

    // Update is called once per frame
    public void Click()
    {
        if (state) scan.ClickStop();
        else scan.Run();

        state = !state;
    }

    private void Update()
    {
        if (SimpleDemo.value != null)
        {
            QRvalue = SimpleDemo.value;
            SimpleDemo.value = null;
            state = !state;
        }
    }

}
