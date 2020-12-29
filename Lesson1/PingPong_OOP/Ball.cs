using System;

namespace PingPong_OOP
{
    public class Ball
    {
        public int X, Y, PreX, PreY, SpdX, SpdY;

        private readonly int startX, startY;
        
        private static Random rnd = new Random(DateTime.Now.Millisecond);

        public Ball(int startX, int startY)
        {
            // Check
            this.startX = startX;
            this.startY = startY;
            
            Reset();
        }
        
        public void Reset()
        {
            X = startX;
            Y = startY;
            GetRandomDirectionBall();
        }
        
        private void GetRandomDirectionBall()
        {
            SpdX = rnd.NextDouble() < 0.5 ? 1 : -1;
            SpdY = rnd.NextDouble() < 0.5 ? 1 : -1;
        }
        
        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.White;
            
            Console.SetCursorPosition(X, Y);
            Console.Write(' ');

            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void Clear()
        {
            Console.SetCursorPosition(PreX, PreY); 
            Console.Write(' ');
        }
        
        public void Move()
        {
            PreX = X;
            PreY = Y;
            
            X += SpdX;
            Y += SpdY;
        }
    }
}