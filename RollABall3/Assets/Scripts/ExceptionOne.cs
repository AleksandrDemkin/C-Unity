using System;
using UnityEngine;
using UnityEngine.UI;

namespace RollABall.ExceptionOne
{

    public sealed class ExceptionOne : MonoBehaviour, IDisposable
    {
        public Text _finishGameLabel;
        private ListInteractableObject _interactiveObject;
        private DisplayEndGame _displayEndGame;
        private void Awake()
        {
            _interactiveObject = new ListInteractableObject();
            _displayEndGame = new DisplayEndGame(_finishGameLabel);
            foreach (var o in _interactiveObject)
            {
                if (o is BadBonus badBonus)
                {
                    badBonus.CaughtPlayer += CaughtPlayer;
                    badBonus.CaughtPlayer += _displayEndGame.GameOver;
                }
            }
        }
        private void CaughtPlayer(object value, CaughtPlayerEventArgs args)
        {
            Time.timeScale = 0.0f;
        }
        private void Update()
        {
            #region ExceptionOne

            try
            {
                // for (var i = 0; i < _interactiveObject.Lenght; i++)
                for (var i = 0; i < _interactiveObject.Count; i++)
                {
                    var interactiveObject = _interactiveObject[i];
                    if (interactiveObject == null)
                    {
                        continue;
                    }

                    if (interactiveObject is IFlay flay)
                    {
                        flay.Flay();
                    }

                    if (interactiveObject is IFlicker flicker)
                    {
                        flicker.Flicker();
                    }

                    if (interactiveObject is IRotation rotation)
                    {
                        rotation.Rotation();
                    }
                }
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
            finally
            {
                for (var i = 0; i < _interactiveObject.Count; i++)
                {
                    var interactiveObject = _interactiveObject[i];
                    if (interactiveObject == null)
                    {
                        continue;
                    }

                    if (interactiveObject is IFlay flay)
                    {
                        flay.Flay();
                    }

                    if (interactiveObject is IFlicker flicker)
                    {
                        flicker.Flicker();
                    }

                    if (interactiveObject is IRotation rotation)
                    {
                        rotation.Rotation();
                    }
                } 
            }

            #endregion
        }
        public void Dispose()
        {
            foreach (var o in _interactiveObject)
            {
                if (o is InteractiveObject interactiveObject)
                {
                    if (o is BadBonus badBonus)
                    {
                        badBonus.CaughtPlayer -= CaughtPlayer;
                        badBonus.CaughtPlayer -= _displayEndGame.GameOver;
                    }
                    Destroy(interactiveObject.gameObject);
                }
            }
        }
    }
}
