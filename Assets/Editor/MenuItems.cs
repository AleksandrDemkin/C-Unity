using UnityEditor;

namespace EditorTest
{
    public class MenuItems
    {
        [MenuItem("My menu/My menu window")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MenuWindow), false, "My menu");
        }
        [MenuItem("Assets/My menu/My menu window")]
        private static void LoadAdditiveScene()
        {
        }
        [MenuItem("Assets/Create/My menu/My menu window")]
        private static void AddConfig()
        {
        }
        [MenuItem("CONTEXT/Rigidbody/My menu/My menu window")]
        private static void NewOpenForRigidBody()
        {
        }
        [MenuItem("CONTEXT/Transform/My menu/My menu window")]
        private static void NewOpenForTransform()
        {
        }
    }
}
