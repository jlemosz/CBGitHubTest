using UnityEditor;
class MyEditorScript
{
   static void PerformBuild ()
   {
       BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
       buildPlayerOptions.scenes = new[] {"Assets/Scenes/SampleScene.unity"};
       buildPlayerOptions.target = BuildTarget.StandaloneWindows64;
       buildPlayerOptions.options = BuildOptions.None;
       buildPlayerOptions.locationPathName = "Build";
       BuildPipeline.BuildPlayer(buildPlayerOptions);
   }
}