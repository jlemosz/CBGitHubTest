using UnityEngine;

public static class PreExport
{
    public static void DumpDefines()
    {
        var defines = UnityEditor.PlayerSettings.GetScriptingDefineSymbolsForGroup(UnityEditor.EditorUserBuildSettings.selectedBuildTargetGroup);
        Debug.Log("======================Defines: " + defines);
    }
}
