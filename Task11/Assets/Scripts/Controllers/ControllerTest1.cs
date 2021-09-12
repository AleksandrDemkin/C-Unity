using RollABall.SaveDirectory;

namespace RollABall
{
    internal sealed class ControllerTest1
    {
        private readonly ISaveGold _saveGold;

        public ControllerTest1(ISaveGold saveGold)
        {
            _saveGold = saveGold;
        }

        private void NameMethod()
        {
            _saveGold.SaveGold(7);
        }
    }
}
