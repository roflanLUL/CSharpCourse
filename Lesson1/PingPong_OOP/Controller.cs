using System;

namespace PingPong_OOP
{
    abstract class Controller
    {
        public Racket racket;
        public int Score;
        public void Move()
        {
            if (racket.Shift == 0) return;
            if (racket.Shift < 0)
            {
                if (racket.Y > 2)
                {
                    racket.PreY = racket.Y;
                    racket.Y -= 1;
                }
            }
            else
            {
                if (racket.Y < racket.maxHeight - 2)
                {
                    racket.PreY = racket.Y;
                    racket.Y += 1;
                }
            }
            racket.Shift = 0;
        }
        
        public void Clear()
        {
            if (racket.PreY == racket.Y) return;
            Console.SetCursorPosition(racket.X, racket.PreY + 2); Console.Write(' ');
            Console.SetCursorPosition(racket.X, racket.PreY - 2); Console.Write(' ');
        }
        
        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.White;

            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(racket.X, racket.Y + i - 2);
                Console.Write(' ');
            }

            Console.BackgroundColor = ConsoleColor.Black;
        }
        
        public abstract void Controll();
    }
}