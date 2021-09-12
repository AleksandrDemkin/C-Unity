using UnityEditor;
using UnityEngine;

namespace EditorTest
{
    [CustomEditor(typeof(TestScript))]
    public sealed class TestScriptEditor : UnityEditor.Editor
    {
        private bool _isPressButtonOk;

        public override void OnInspectorGUI()
        {
            //DrawDefaultInspector();
            TestScript testTarget = (TestScript) target;
            testTarget.count = EditorGUILayout.IntSlider(testTarget.count, 10, 50);
            testTarget.offset = EditorGUILayout.IntSlider(testTarget.offset, 1, 5);
            testTarget.obj = EditorGUILayout.ObjectField("Object to create",
                testTarget.obj, typeof(GameObject), false) as GameObject;
            var isPressButton = GUILayout.Button("Create object by button click",
                EditorStyles.miniButtonLeft);
            _isPressButtonOk = GUILayout.Toggle(_isPressButtonOk, "Ok");
            if (isPressButton)
            {
                testTarget.CreateObj();
                _isPressButtonOk = true;
            }

            if (_isPressButtonOk)
            {
                testTarget.Test = EditorGUILayout.Slider(testTarget.Test, 10, 50);
                EditorGUILayout.HelpBox("Button clicked", MessageType.Warning);
                var isPressAddButton = GUILayout.Button("Add Component",
                    EditorStyles.miniButtonLeft);
                var isPressRemoveButton = GUILayout.Button("Remove Component",
                    EditorStyles.miniButtonLeft);

                if (isPressAddButton)
                {
                    testTarget.AddComponent();
                }

                if (isPressRemoveButton)
                {
                    testTarget.RemoveComponent();
                }
            }
        }
    }
}
