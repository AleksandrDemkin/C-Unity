using UnityEngine.UI;
using UnityEngine;

namespace RollABall
{
    
    public sealed class DisplayBonuses : IView
    {
        private Text _text;
        private int _point;
        public DisplayBonuses()
        {
            _text = Object.FindObjectOfType<Text>();
        }
        
        public void Display(int value)
        {
            _point += value;
            _text.text = $"You got {_point} of GoodBonus";
            _text.text = $"You got {_point} of GoodBonusForWin";
        }
    }

    class MyClassrtty : IView
    {
        public void Display(int value)
        {
            throw new System.NotImplementedException();
        }
    }
}