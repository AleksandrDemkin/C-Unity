﻿namespace RollABall
{

    public sealed class PlayerBall : Player
    {
        private void FixedUpdate()
        {
            Move();
            Jump();
        }
    }
}