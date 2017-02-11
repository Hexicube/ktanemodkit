using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(ComponentCategory))]
public class ComponentCategory : Editor {
    public string CategoryName;
    public string[] ComponentNames;

    public override void OnInspectorGUI()
    {
        if (target != null)
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(serializedObject.FindProperty("CategoryName"), false);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("ComponentNames"), true);
        }

        serializedObject.ApplyModifiedProperties();
    }
}
