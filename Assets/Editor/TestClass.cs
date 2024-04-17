using UnityEngine;

public static class TestClass
{
    public static void PrintTarget()
    {
        var target = UnityEditor.EditorUserBuildSettings.activeBuildTarget;
        var group = UnityEditor.BuildPipeline.GetBuildTargetGroup(target);
           
#if UNITY_ANDROID
            Debug.Log("ANDROID GROUP: " + group.ToString());
#elif UNITY_IOS
            Debug.Log("iOS GROUP: " + group.ToString());
#endif

    }
}
