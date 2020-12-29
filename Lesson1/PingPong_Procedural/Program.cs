using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace PingPong_Procedural
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern ushort GetAsyncKeyState(int vKey);

        public static bool IsKeyPushedDown(ConsoleKey vKey)
        {
            return 0 != (GetAsyncKeyState((int) vKey) & 0x8000);
        }
        
        const int width = 100, height = 50;
        
        static Random rnd = new Random(DateTime.Now.Millisecond);
        
        static int racket1X, racket1Y, racket1PreX, racket1PreY, shiftRacket1, score1;
        static int racket2X, racket2Y, racket2PreX, racket2PreY, shiftRacket2, score2;

        static int ballX, ballY, ballPreX, ballPreY, ballSpdX, ballSpdY;
        
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WindowWidth = width + 1;
            Console.WindowHeight = height + 1;
            
            Init();
            
            while (true)
            {
                Control();
                
                MoveObjects();

                Draw();

                Thread.Sleep(1000 / 30);
            }
        }

        static void CheckCollision()
        {
            if (CheckCollisionWithRacket(racket1X, racket1Y)) ballSpdX = 1;
            if (CheckCollisionWithRacket(racket2X, racket2Y)) ballSpdX = -1;

            if (ballY <= 0) ballSpdY = 1;
            if (ballY >= height - 1) ballSpdY = -1;

            bool CheckCollisionWithRacket(int x, int y)
            {
                return (x == ballX) && ((y - 2 >= ballY) || (y + 2 >= ballY));
            }
        }
        static void CheckGoal()
        {
            if (ballX == width)
            {
                score1++;
                ResetBall();
            }
            
            if (ballX <= 0)
            {
                score2++;
                ResetBall();   
            }
        }

        static void ResetBall()
        {
            ballX = width / 2;
            ballY = height / 2;
            GetRandomDirectionBall();
        }
        
        static void Control()
        {
            if (IsKeyPushedDown(ConsoleKey.Escape)) Environment.Exit(0);
                
            if (IsKeyPushedDown(ConsoleKey.W)) shiftRacket1--;
            if (IsKeyPushedDown(ConsoleKey.S)) shiftRacket1++;
                
            if (IsKeyPushedDown(ConsoleKey.UpArrow)) shiftRacket2--;
            if (IsKeyPushedDown(ConsoleKey.DownArrow)) shiftRacket2++;
        }

        static void MoveObjects()
        {
            MoveRacket(ref racket1PreY, ref racket1Y, ref shiftRacket1);
            MoveRacket(ref racket2PreY, ref racket2Y, ref shiftRacket2);
            MoveBall();
            
            CheckGoal();
            CheckCollision();
        }
        static void Draw()
        {
            ClearRacket(racket1X, racket1PreY, racket1Y);
            ClearRacket(racket2X, racket2PreY, racket2Y);
            ClearBall();

            DrawRacket(racket1X, racket1Y);
            DrawRacket(racket2X, racket2Y);
            DrawBall();

            Console.Title = $"{score1} : {score2}";
        }
        
        static void Init()
        {
            racket1PreX = racket1X = 2;
            racket1PreY = racket1Y = height / 2;

            racket2PreX = racket2X = width - 2;
            racket2PreY = racket2Y = height / 2;
            
            shiftRacket1 = shiftRacket2 = 0;

            ResetBall();
        }

        static void GetRandomDirectionBall()
        {
            ballSpdX = rnd.NextDouble() < 0.5 ? 1 : -1;
            ballSpdY = rnd.NextDouble() < 0.5 ? 1 : -1;
        }
        
        static void DrawBall()
        {
            Console.BackgroundColor = ConsoleColor.White;
            
            Console.SetCursorPosition(ballX, ballY);
            Console.Write(' ');

            Console.BackgroundColor = ConsoleColor.Black;
        }
        
        static void DrawRacket(int x, int y)
        {
            Console.BackgroundColor = ConsoleColor.White;

            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(x, y + i - 2);
                Console.Write(' ');
            }

            Console.BackgroundColor = ConsoleColor.Black;
        }
        
        static void ClearBall()
        {
            Console.SetCursorPosition(ballPreX, ballPreY); 
            Console.Write(' ');
        }
        
        static void ClearRacket(int x, int preY, int y)
        {
            if (preY == y) return;
            Console.SetCursorPosition(x, preY + 2); Console.Write(' ');
            Console.SetCursorPosition(x, preY - 2); Console.Write(' ');
        }
        
        static void MoveBall()
        {
            ballPreX = ballX;
            ballPreY = ballY;
            
            ballX += ballSpdX;
            ballY += ballSpdY;
        }
        
        static void MoveRacket(ref int racketPreY, ref int racketY, ref int shiftRacket)
        {
            if (shiftRacket == 0) return;
            if (shiftRacket < 0)
            {
                if (racketY > 2)
                {
                    racketPreY = racketY;
                    racketY -= 1;
                }
            }
            else
            {
                if (racketY < height - 2)
                {
                    racketPreY = racketY;
                    racketY += 1;
                }
            }
            shiftRacket = 0;
        }
    }
}