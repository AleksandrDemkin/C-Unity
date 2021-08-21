using System.Collections.Generic;

namespace RollABall
{
    public sealed class GoodBonusComparer : IComparer<GoodBonus>, IComparer<BonusWin>
    {
        public int Compare(GoodBonus x, GoodBonus y)
        {
            if (x.Point < y.Point)
            {
                return 1;
            }
            if (x.Point > y.Point)
            {
                return -1;
            }
            return 0;
        }
        
        public int Compare(BonusWin x, BonusWin y)
        {
            if (x.Point < y.Point)
            {
                return 1;
            }
            if (x.Point > y.Point)
            {
                return -1;
            }
            return 0;
        }
    }
}

