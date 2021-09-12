using UnityEngine;

namespace RollABall
{
    public sealed class MiniMapController : ILateExecute
    {
        private readonly Transform _owner;
        private readonly Transform _target;

        public MiniMapController(Transform owner, Transform target)
        {
            _owner = owner;
            _target = target;
        }
        
        public void LateExecute()
        {
            var newPosition = _target.position;
            newPosition.y = _owner.position.y;
            _owner.position = newPosition;
            _owner.rotation = Quaternion.Euler(90, _target.eulerAngles.y, 0);
        }
    }
}
