using System.IO;
using System.Linq;
using UnityEngine;

namespace RollABall
{
    public class Test : MonoBehaviour
    {
        private void Start()
        {
            var interactableObject = new ListInteractableObject();
            while (interactableObject.MoveNext())
            {
                print(interactableObject.Current);
            }
            
            var goodBonusComparer = new GoodBonusComparer();
            var objects = FindObjectsOfType<GoodBonus>().ToList();
            var bonus = GameObject.Find("Point 4").GetComponent<GoodBonus>();
            objects.Remove(bonus);
            print($"{objects.Contains(bonus)}");
            objects.Sort(goodBonusComparer);
            foreach (var goodBonus in objects)
            {
                print($"{goodBonus.name} - {goodBonus.Point}");
            }
            
            FindObjectOfType<BadBonus>().Clone();
            
            using (StreamReader reader = new StreamReader("example path"))
            {
                
            }
            
            var objects1 = new ListInteractableObject();
            for (int i = 0; i < objects1.Count; i++)
            {
                print($"{objects1[i]}");
            }

        }
    }
}
