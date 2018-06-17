using UnityEditor;

namespace Assets
{
    public class Batch
    {
        public static void OpenProject()
        {
            EditorApplication.ExecuteMenuItem("Assets/Open C# Project");         
        }
    }
}