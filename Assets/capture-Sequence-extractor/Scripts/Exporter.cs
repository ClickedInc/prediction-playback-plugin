using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Exporter : MonoBehaviour {

    [MenuItem("Clicked/Export capture-sequence-extractor!!")]
    public static void Exporting()
    {
        string prefabfilename = "Assets/capture-sequence-extractor";

        string exportPath = EditorUtility.SaveFilePanel("Export capture-sequence-extractor", "", "capture-sequence-extractor", "unitypackage");

        AssetDatabase.ExportPackage(prefabfilename, exportPath,
        ExportPackageOptions.IncludeDependencies | ExportPackageOptions.Recurse);

        EditorUtility.DisplayDialog("Congratulation!", "The package is exported successfully.", "OK.");
    }

}
