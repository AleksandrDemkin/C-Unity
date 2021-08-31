using UnityEngine;

namespace Lesson7
{
    public class Test : MonoBehaviour
    {
        private void Start()
        {
            string s = "Hello, hello";
            char c = 'l';
            int i = s.CharCount(c);
            Debug.Log(i);
        }
    }
}
