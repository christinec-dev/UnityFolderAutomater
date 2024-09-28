using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using System.IO;
public class AutoFolders : EditorWindow
{
    [MenuItem("Assets/Create Base Folders")]
    private static void SetUpFolders()
    {
        AutoFolders window = ScriptableObject.CreateInstance<AutoFolders>();
        window.position = new Rect(Screen.width / 2, Screen.height / 2, 400, 150);
        window.ShowPopup();
    }
    private static void CreateBaseFolders()
    {
        List<string> folders = new List<string>
        {
            "Animations",
            "Audio",
            "Editor",
            "Materials",
            "Meshes",
            "Prefabs",
            "Scripts",
            "Scenes",
            "Shaders",
            "Resources",
            "Textures",
            "UI"
        };
        foreach (string folder in folders)
        {
            if (!Directory.Exists("Assets/" + folder))
            {
                Directory.CreateDirectory("Assets/" + folder);
            }
        }
        List<string> uiAssets = new List<string>
        {
            "Images",
            "Fonts",
            "Icon"
        };
        foreach (string subfolder in uiAssets)
        {
            if (!Directory.Exists("Assets/" + "/UI/" + subfolder))
            {
                Directory.CreateDirectory("Assets/" + "/UI/" + subfolder);
            }
        }
        AssetDatabase.Refresh();
    }
    void OnGUI()
    {
        CreateBaseFolders();
        this.Close();
    }
}
