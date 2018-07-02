using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceCapture : MonoBehaviour {

    public static string folder = "CaptureFolder/Sample/";

    int num;

    Handler handler;

    public static string ScreenShotName(int width, int height, int num)
    {
        return string.Format("{0}_{1}_{2}.png",
                             folder,
                             System.DateTime.Now.ToString("hh-mm-ss"), num
                             );
    }

    void Awake () {

        handler = FindObjectOfType<Handler>();

        if (handler.folder != string.Empty)
            folder = handler.folder;

        System.IO.Directory.CreateDirectory(folder);
    }

    public void Capture () {

        ScreenCapture.CaptureScreenshot(ScreenShotName(256,256, num));
        num++;
    }
}
