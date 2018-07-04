using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureManager : MonoBehaviour {

    public static string folder = "CaptureFolder/Sample/";

    CSVSimulator csvSimulator;

    static int captureNum;

    public static string ScreenShotName(int width, int height, float time)
    {
        return string.Format("{0}{1}_{2}.png",
                             folder,
                             captureNum,
                             time
                             //System.DateTime.Now.ToString("hh-mm-ss")
                             );
    }

    public void Capture (float time) {

        ScreenCapture.CaptureScreenshot(ScreenShotName(256,256, time));
        captureNum++;
    }
}
