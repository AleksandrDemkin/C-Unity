using UnityEngine;

namespace RollABall
{
    public class ExampleClass : MonoBehaviour
    {
        void Start()
        {
            GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
            Renderer rend = plane.GetComponent<Renderer>();
            rend.material.mainTexture = Resources.Load("glass") as Texture;
            
            GameObject player1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Renderer rend1 = player1.GetComponent<Renderer>();
            rend.material = Resources.Load("Color") as Material;
        }
    }
}

