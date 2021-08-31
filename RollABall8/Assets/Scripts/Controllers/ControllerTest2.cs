using RollABall.NewDir;

namespace RollABall
{
    internal sealed class ControllerTest2
    {
        private readonly ISaveHp _test1;

        public ControllerTest2(ISaveHp test1)
        {
            _test1 = test1;
        }

        private void NameMethod()
        {
            _test1.SaveHp(7.0f);
        }
    }
}
