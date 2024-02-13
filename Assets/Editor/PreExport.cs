using UnityEditor;

public class PreExport
{
    public static void PrintDefines()
    {
        string[] defines;
        PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildPipeline.GetBuildTargetGroup(EditorUserBuildSettings.activeBuildTarget), out defines);
        UnityEngine.Debug.Log("Custom defines from player settings: " + string.Join(";", defines));
    }
}