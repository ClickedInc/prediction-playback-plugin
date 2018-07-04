using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;

public class CSVSimulator : MonoBehaviour {

    List<Dictionary<string, object>> data;

    private GameObject head;
    private CaptureManager timeWarpingCamera;
    private GameObject anchor;

    GameObject leftTexture;
    GameObject rightTexture;
    GameObject light;

    int qf;
    int qh;

    string dataName;

    [SerializeField] private bool UseTimeWarping;
    [SerializeField] private bool UsePredictedData;
    [SerializeField] private string csvPath;

    public string capturePath;
    [SerializeField] private int captureLength;
    [SerializeField] int captureFrame;
    [SerializeField] int captureWidth;
    [SerializeField] int captureHeight;

    private void Awake()
    {
        if (captureHeight == 0 && captureWidth ==0)
        {
            captureWidth = 2048;
            captureHeight = 1024;
        }
        Init();      
    }

    void Update () {

        if (TimeWarpSetting(UseTimeWarping))
            TimeWarping(UsePredictedData);
        else
            NonTimeWarping(UsePredictedData);

    }
    private void CaptureCameraPosSetting()
    {

    }
    private void TimeWarping(bool isPredict)
    {
            string[] rotateDataQF = rotateDataSetting(isPredict, qf);
            string[] rotateDataQH = rotateDataSetting(isPredict, qh);

        Debug.Log(rotateDataQF[1]);

            transform.rotation = new Quaternion(
                float.Parse(rotateDataQF[1]),
                float.Parse(rotateDataQF[2]),
                float.Parse(rotateDataQF[3]),
                float.Parse(rotateDataQF[4])
                );

            head.transform.rotation = transform.rotation;

            anchor.transform.rotation = new Quaternion(
                float.Parse(rotateDataQH[1]),
                float.Parse(rotateDataQH[2]),
                float.Parse(rotateDataQH[3]),
                float.Parse(rotateDataQH[4])
                );

        if (qf <= captureLength)
        {
            //timeWarpingCamera.Capture(float.Parse(data[qf]["time_stamp"].ToString()));
        }

        if (qf++ >= 6)
        {
            qh++; 
        }        
    }

    private void NonTimeWarping(bool isPredict)
    {

            string[] rotateDataQF = rotateDataSetting(isPredict, qf);
        Debug.Log(rotateDataQF[1]);
        transform.rotation = new Quaternion(
                float.Parse(rotateDataQF[1]),
                float.Parse(rotateDataQF[2]),
                float.Parse(rotateDataQF[3]),
                float.Parse(rotateDataQF[4])
                );

            head.transform.rotation = transform.rotation;

            anchor.transform.rotation = transform.rotation;

            if (qf <= captureLength)
            {
                //timeWarpingCamera.Capture(float.Parse(data[qf]["time_stamp"].ToString()));
            }
            qf++;

 
    }


    private string[] rotateDataSetting(bool isPredict, int dataNum)
    {
        string[] rotateData;

        if (UsePredictedData)
        {
            rotateData = data[dataNum]["predicted_ori"].ToString().Split(',', '(', ')');
        }
        else
        {
            rotateData = data[dataNum]["original_ori"].ToString().Split(',', '(', ')');
        }
        return rotateData;

    }

    bool TimeWarpSetting(bool IsTimeWarping)
    {
        if (IsTimeWarping)
            return true;
        else
            return false;
    }

    private void Init()
    {
        GameObject captureModule = Instantiate(Resources.Load("CaptureModule") as GameObject);

        head = GameObject.Find("Head");
        timeWarpingCamera = GameObject.Find("TimeWarpingCamera").GetComponent<CaptureManager>();
        anchor = GameObject.Find("Anchor");

        leftTexture = GameObject.Find("LeftTargetTexture");
        rightTexture = GameObject.Find("RightTargetTexture");

        captureModule.transform.position = new Vector3(100, 0, 0);
        leftTexture.transform.position = new Vector3(99.5f, 0, 0.866f);
        rightTexture.transform.position = new Vector3(100.5f, 0, 0.866f);

        Time.captureFramerate = captureFrame;

        PlayerSettings.defaultScreenHeight = captureHeight;
        PlayerSettings.defaultScreenWidth = captureWidth;

        data = CSVReader.Read(csvPath);


    }
}
