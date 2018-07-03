using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureManager : MonoBehaviour {

    public static string folder = "CaptureFolder/Sample/";

    CSVSimulator csvSimulator;

    public static string ScreenShotName(int width, int height, float time)
    {
        return string.Format("{0}{1}_{2}.png",
                             folder,
                             time,
                             System.DateTime.Now.ToString("hh-mm-ss")
                             );
    }

    void Awake () {

        csvSimulator = FindObjectOfType<CSVSimulator>();

        if (csvSimulator.capturePath != string.Empty)
            folder = csvSimulator.capturePath;

        System.IO.Directory.CreateDirectory(folder);
    }

    public void Capture (float time) {

        ScreenCapture.CaptureScreenshot(ScreenShotName(256,256, time));
    }
}
