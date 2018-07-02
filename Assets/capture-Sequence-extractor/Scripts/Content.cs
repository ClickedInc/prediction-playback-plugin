using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Content : MonoBehaviour {

    List<Dictionary<string, object>> data;
    private List<int> datas = new List<int>();

    [SerializeField] private GameObject head;
    [SerializeField] private SequenceCapture timeWarpingCamera;
    [SerializeField] private GameObject anchor;

    int qf;
    int qh;

    int resWidth = 256;
    int resHeight = 256;

    int datadata;

    bool isTimeWarping;
    bool isPredicting;

    Handler handler;

    private void Awake()
    {
        handler = FindObjectOfType<Handler>();

        //PredictSetting(handler.IsPredicting);

        //thisCamera = GetComponent<Camera>();

        for (int i = 0; i < 1000; i++)
        {
            datas.Add(datadata);
            if (i < 50)
                datadata++;
            else if (i > 50 && i < 100)
                datadata = datadata;
            else if (i > 100 && i < 200)
                datadata++;
            else if (i > 200 && i < 300)
                datadata = datadata;
            else if (i > 300 && i < 400)
                datadata++;
            else if (i > 400 && i < 500)
                datadata = datadata;
            else if (i > 500 && i < 600)
                datadata++;
            else if (i > 600 && i < 700)
                datadata = datadata;
            else if (i > 700 && i < 000)
                datadata++;
            else if (i > 800 && i < 900)
                datadata = datadata;
            else
                datadata++;

        } 

        
    }

    int a;
    void Update () {

        if (TimeWarpSetting(handler.IsTimeWarping))
            TimeWarping();
        else
            NonTimeWarping();

    }

    private void TimeWarping()
    {
        if (qf <= handler.captureLength)
        {
            //transform.eulerAngles = new Vector3(
            //    float.Parse(data[qf]["x"].ToString()), 
            //    float.Parse(data[qf]["y"].ToString()), 
            //    float.Parse(data[qf]["z"].ToString())
            //    );
            transform.eulerAngles = new Vector3(0, a++, 0);

            //followingCamera.transform.eulerAngles = new Vector3(
            //    float.Parse(data[qf]["x"].ToString()),
            //    float.Parse(data[qf]["y"].ToString()),
            //    float.Parse(data[qf]["z"].ToString())
            //    );
            head.transform.eulerAngles = new Vector3(0, datas[qf], 0);

            //thisCamera.targetTexture = rt;

            //thisCamera.Render();

            //anchor.transform.eulerAngles = new Vector3(
            //    float.Parse(data[qh]["x"].ToString()),
            //    float.Parse(data[qh]["y"].ToString()),
            //    float.Parse(data[qh]["z"].ToString())
            //    );
            anchor.transform.eulerAngles = new Vector3(0, datas[qh], 0);

            //transform.eulerAngles = new Vector3(
            //    float.Parse(data[qh]["x"].ToString()),
            //    float.Parse(data[qh]["y"].ToString()),
            //    float.Parse(data[qh]["z"].ToString())
            //    );
            transform.eulerAngles = new Vector3(0, a++, 0);

            //thisCamera.Render();

            timeWarpingCamera.Capture();

            if (qf++ >= 6)
            {
                qh++;
            }
        }
    }

    private void NonTimeWarping()
    {
        if (qf <= handler.captureLength)
        {
            //transform.eulerAngles = new Vector3(
            //    float.Parse(data[qf]["x"].ToString()), 
            //    float.Parse(data[qf]["y"].ToString()), 
            //    float.Parse(data[qf]["z"].ToString())
            //    );
            transform.eulerAngles = new Vector3(0, a++, 0);

            //followingCamera.transform.eulerAngles = new Vector3(
            //    float.Parse(data[qf]["x"].ToString()),
            //    float.Parse(data[qf]["y"].ToString()),
            //    float.Parse(data[qf]["z"].ToString())
            //    );
            head.transform.eulerAngles = new Vector3(0, datas[qf], 0);

            //thisCamera.targetTexture = rt;

            //thisCamera.Render();

            //anchor.transform.eulerAngles = new Vector3(
            //    float.Parse(data[qh]["x"].ToString()),
            //    float.Parse(data[qh]["y"].ToString()),
            //    float.Parse(data[qh]["z"].ToString())
            //    );
            anchor.transform.eulerAngles = new Vector3(0, datas[qf], 0);

            //transform.eulerAngles = new Vector3(
            //    float.Parse(data[qh]["x"].ToString()),
            //    float.Parse(data[qh]["y"].ToString()),
            //    float.Parse(data[qh]["z"].ToString())
            //    );
            transform.eulerAngles = new Vector3(0, a++, 0);

            //thisCamera.Render();

            timeWarpingCamera.Capture();


            qf++;
            
        }
    }

    void PredictSetting(bool IsPredicing)
    {
        if (IsPredicing)
            data = CSVReader.Read("predict");
        else
            data = CSVReader.Read("nonPredict");

    }
    bool TimeWarpSetting(bool IsTimeWarping)
    {
        if (IsTimeWarping)
            return true;
        else
            return false;
    }

}
