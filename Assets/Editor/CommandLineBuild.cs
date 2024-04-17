using UnityEditor;
using UnityEngine;

    public static class CommandLineBuild
    {
        public static void SetEnvironment()
        {
            var target = EditorUserBuildSettings.activeBuildTarget;
            var group = BuildPipeline.GetBuildTargetGroup(target);
            
#if UNITY_ANDROID
            Debug.Log("ANDROID GROUP: " + group.ToString());
#elif UNITY_IOS
            Debug.Log("iOS GROUP: " + group.ToString());
#endif
        }
    }
