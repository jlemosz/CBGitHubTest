using UnityEditor;
using UnityEngine;

public static class PreExport
{
    public static void PrintDefines()
    {
        string[] defines;
        PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildPipeline.GetBuildTargetGroup(EditorUserBuildSettings.activeBuildTarget), out defines);
        Debug.Log("Custom defines from player settings: " + string.Join(";", defines));
    }
}