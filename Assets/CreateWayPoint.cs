using System;
using UnityEngine;

namespace EditorTest
{
    public class CreateWayPoint : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        private PathBot _rootWayPoint;

        public void InstantiateObj(Vector3 pos)
        {
            if (!_rootWayPoint)
            {
                _rootWayPoint = new GameObject("WayPoint").AddComponent<PathBot>();
            }

            if (_prefab != null)
            {
                Instantiate(_prefab, pos, Quaternion.identity, _rootWayPoint.transform);
            }
            else
            {
                throw new Exception($"There is no prefab {typeof(CreateWayPoint)} {gameObject.name}");
            }
        }
    }
}
