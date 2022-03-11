using UnityEditor;

namespace Unity.CsharpTemplates.Editor
{
    public static class TemplateActions
    {
        const string TemplatesRoot = "Packages/com.unity.csharp-templates/Editor/ScriptTemplates";

        [MenuItem("Assets/Create/C# Class/ScriptableObject")]
        public static void CreateNewScriptableObject()
        {
            CreateNewFromTemplate("ScriptableObject", "NewScriptableObject.cs");
        }

        [MenuItem("Assets/Create/C# Class/EditorWindow")]
        public static void CreateNewEditorWindow()
        {
            CreateNewFromTemplate("EditorWindow", "NewEditorWindow.cs");
        }

        public static void CreateNewFromTemplate(string template, string filename)
        {
#if UNITY_2020_2_OR_NEWER
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile($"{TemplatesRoot}/{template}.txt", filename);
#else
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile($"{TemplatesRoot}/{template}_NoNamespace.txt", filename);
#endif
        }
    }
}