using UnityEditor;
using UnityEngine;

namespace EditorTest
{
    public class MenuWindow : EditorWindow
    {
        public static GameObject ObjectInstantiate;
        public string _nameObject = "Test object";
        public bool _groupEnabled;
        public bool _randomColor = true;
        public int _countObject = 1;
        public float _radius = 10;

        private void OnGUI()
        {
            GUILayout.Label("Base settings", EditorStyles.boldLabel);
            ObjectInstantiate =
                EditorGUILayout.ObjectField("Object to enter",
                        ObjectInstantiate, typeof(GameObject), true)
                    as GameObject;
            _nameObject = EditorGUILayout.TextField("Object name", _nameObject);
            _groupEnabled = EditorGUILayout.BeginToggleGroup("Advanced settings", _groupEnabled);
            _randomColor = EditorGUILayout.Toggle("Random color", _randomColor);
            _countObject = EditorGUILayout.IntSlider("Objects amount", _countObject, 1, 20);
            _radius = EditorGUILayout.Slider("Circle radius", _radius, 10, 30);
            EditorGUILayout.EndToggleGroup();

            var button = GUILayout.Button("Create objects");
            if (button)
            {
                if (ObjectInstantiate)
                {
                    GameObject root = new GameObject("Root");
                    for (int i = 0; i < _countObject; i++)
                    {
                        float angle = i * Mathf.PI * 2 / _countObject;
                        Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle) * _radius);
                        GameObject temp = Instantiate(ObjectInstantiate, pos, Quaternion.identity);
                        temp.name = _nameObject + "(" + i + ")";
                        temp.transform.parent = root.transform;
                        var tempRenderer = temp.GetComponent<Renderer>();
                        if (tempRenderer && _randomColor)
                        {
                            tempRenderer.material.color = Random.ColorHSV();
                        }
                    }
                }
            }
        }
    }
}
