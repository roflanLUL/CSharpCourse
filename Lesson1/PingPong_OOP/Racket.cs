using System;

namespace PingPong_OOP
{
    public class Racket
    {
        public int X, Y, PreX, PreY, Shift;

        public readonly int maxHeight;
        
        public Racket(int x, int y, int maxHeight)
        {
            // Check
            PreX = X = x;
            PreY = Y = y / 2;

            this.maxHeight = maxHeight;
        }

        public bool IsCollision(int x, int y)
        {
            return (X == x) && ((Y - 2 >= y) || (Y + 2 >= y));
        }
    }
}