using UnityEngine;

namespace RollABall
{
    /// <summary>
    /// DZ MVC
    /// </summary>
    public sealed class Map : MonoBehaviour
    {
        private Transform _player;
        private void Start()
        {
            var main = Camera.main;
            _player = main.transform;
            transform.parent = null;
            transform.rotation = Quaternion.Euler(90.0f, 0, 0);
            transform.position = _player.position + new Vector3(0, 5.0f, 0);

            var rt = Resources.Load<RenderTexture>("Map/MapRenderTexture");

            var component = GetComponent<Camera>();
            component.targetTexture = rt;
            component.depth = --main.depth;
        }

        private void LateUpdate()
        {
            var newPosition = _player.position;
            newPosition.y = transform.position.y;
            transform.position = newPosition;
            transform.rotation = Quaternion.Euler(90, _player.eulerAngles.y, 0);
        }
    }

    #region MVC

    // internal class MapController : ILateExecute
    // {
    //     private readonly Transform _owner;
    //     private readonly Transform _target;
    //
    //     public MapController(Transform owner, Transform target)
    //     {
    //         _owner = owner;
    //         _target = target;
    //     }
    //     
    //     public void LateExecute()
    //     {
    //         var newPosition = _target.position;
    //         newPosition.y = _owner.position.y;
    //         _owner.position = newPosition;
    //         _owner.rotation = Quaternion.Euler(90, _target.eulerAngles.y, 0);
    //     }
    // }
    //
    // internal class MapInitialize : IInitialization
    // {
    //     private readonly Transform _owner;
    //     private readonly Transform _target;
    //
    //     public MapInitialize(Transform owner, Transform target)
    //     {
    //         _owner = owner;
    //         _target = target;
    //     }
    //
    //     public void Initialization()
    //     {
    //         var main = Camera.main;
    //         _owner.parent = null;
    //         _owner.rotation = Quaternion.Euler(90.0f, 0, 0);
    //         _owner.position = _target.position + new Vector3(0, 5.0f, 0);
    //
    //         var rt = Resources.Load<RenderTexture>("Map/MapRenderTexture");
    //
    //         var component = _owner.GetComponent<Camera>();
    //         component.targetTexture = rt;
    //         component.depth = --main.depth;
    //     }
    // }

    #endregion

}