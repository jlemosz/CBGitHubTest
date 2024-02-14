using UnityEngine;

public static class ShowScriptingBackend
{
    public static void ShowBackend()
    {
        UnityEditor.ScriptingImplementation backend = UnityEditor.PlayerSettings.GetScriptingBackend(UnityEditor.BuildTargetGroup.Standalone);
        if (backend != UnityEditor.ScriptingImplementation.IL2CPP)
        {
            Debug.LogError("Backend Is Mono");
        }
        else
        {
            Debug.LogError("Backend is IL2CPP");
        }
    }
}
