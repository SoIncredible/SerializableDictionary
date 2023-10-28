using NUnit.Framework.Internal;
using UnityEditor;
using UnityEngine;

namespace CheckBox.Editor
{
    [CustomEditor(typeof(TestArray))]
    public class ArrayCheckBoxDrawer : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            TestArray testArray = (TestArray)target;
            SerializedProperty testArr = serializedObject.FindProperty("m_testArr");

            base.OnInspectorGUI();

            serializedObject.Update();


            string[] options = testArray.options;
            GUIContent content = new GUIContent("options");
            // content.popupoptions=

            GUIContent popupContent = new GUIContent("Select Option");


            SerializedProperty optionsProperty = serializedObject.FindProperty("options");
            // EditorGUILayout.PropertyField(optionsProperty, new GUIContent(), optionsProperty);
            serializedObject.ApplyModifiedProperties();
        }
    }
}