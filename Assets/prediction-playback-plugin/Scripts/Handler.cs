using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Handler : MonoBehaviour {

    public bool IsTimeWarping;

    public string folder;

    public string csvName;

    public int captureLength;

    [SerializeField] int captureFrame;
    [SerializeField] int captureHeight;
    [SerializeField] int captureWidth;

    private Content cameraHandelr;

    void Awake () {

        Time.captureFramerate = captureFrame;

        cameraHandelr = FindObjectOfType<Content>();

        PlayerSettings.defaultScreenHeight = captureHeight;
        PlayerSettings.defaultScreenWidth = captureWidth;

    }

	void Update () {

    }

}
