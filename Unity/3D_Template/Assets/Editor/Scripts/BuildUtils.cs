using UnityEditor;

public class BuildUtils
{
    [MenuItem("Build/Build WebGL")]
    public static void BuildWebGL()
    {
        BuildPipeline.BuildPlayer(
            new string[] { "Assets/Scenes/3D.unity" },
            "Build/WebGL", 
            BuildTarget.WebGL, 
            BuildOptions.None
        );
    }
}