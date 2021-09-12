using System;
using UnityEngine;
using UnityEngine.UI;

namespace RollABall
{
    public sealed class DisplayEndGame
    {
        private Text _finishGameLabel;
        public DisplayEndGame(GameObject endGame)
        {
            _finishGameLabel = endGame.GetComponentInChildren<Text>();
            _finishGameLabel.text = String.Empty;
        }
        public void GameOver(string name, Color color)
        {
            _finishGameLabel.text = $"Вы проиграли. Вас убил {name} {color} цвета";
        }
    }
    public sealed class DisplayWinGame
    {
        private Text _finishGameLabel;
        public DisplayWinGame(GameObject winGame)
        {
            _finishGameLabel = winGame.GetComponentInChildren<Text>();
            _finishGameLabel.text = String.Empty;
        }
        public void GameOver(string name, Color color)
        {
            _finishGameLabel.text = $"You win.";
        }
    }
}