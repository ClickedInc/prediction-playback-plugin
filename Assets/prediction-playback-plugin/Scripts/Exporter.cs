using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Exporter : MonoBehaviour {

    [MenuItem("Clicked/Export prediction-playback-plugin!!")]
    public static void Exporting()
    {
        string prefabfilename = "Assets/prediction-playback-plugin";

        string exportPath = EditorUtility.SaveFilePanel("Export prediction-playback-plugin", "", "prediction-playback-plugin", "unitypackage");

        AssetDatabase.ExportPackage(prefabfilename, exportPath,
        ExportPackageOptions.IncludeDependencies | ExportPackageOptions.Recurse);

        EditorUtility.DisplayDialog("Congratulation!", "The package is exported successfully.", "OK.");
    }

}
