using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    public int upScaleFactôr = 2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Q)) {
			ScreenCapture.CaptureScreenshot("Screens/"+(System.DateTime.Now.ToString("yy MM dd HH.mm.ss " + Screen.width + "x" + Screen.height) + ".png"), upScaleFactôr);
		}
        if(Input.GetButtonDown("Fire2")){ //Oculus Quest Button B
            ScreenCapture.CaptureScreenshot("Screens/" + (System.DateTime.Now.ToString("yy MM dd HH.mm.ss " + Screen.width + "x" + Screen.height) + ".png"), upScaleFactôr);

        }
    }
}
