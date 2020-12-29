using System;
using System.Threading;

namespace PingPong_OOP
{
    class Program
    {
        const int width = 100, height = 50;

        static Controller leftPlayer;
        static Controller rightPlayer;

        static Ball ball;
        
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
            if (leftPlayer.racket.IsCollision(ball.X, ball.Y)) ball.SpdX = 1;
            if (rightPlayer.racket.IsCollision(ball.X, ball.Y)) ball.SpdX = -1;

            if (ball.Y <= 0) ball.SpdY = 1;
            if (ball.Y >= height - 1) ball.SpdY = -1;
        }
        static void CheckGoal()
        {
            if (ball.X == width)
            {
                leftPlayer.Score++;
                ball.Reset();
            }
            
            if (ball.X <= 0)
            {
                rightPlayer.Score++;
                ball.Reset();   
            }
        }
        static void Control()
        {
            if (WinAPI.IsKeyDown(ConsoleKey.Escape)) Environment.Exit(0);
                
            leftPlayer.Controll();
            rightPlayer.Controll();
        }
        static void MoveObjects()
        {
            leftPlayer.Move();
            rightPlayer.Move();
            ball.Move();
            
            CheckGoal();
            CheckCollision();
        }
        static void Draw()
        {
            leftPlayer.Clear();
            rightPlayer.Clear();
            ball.Clear();

            leftPlayer.Draw();
            rightPlayer.Draw();
            ball.Draw();

            Console.Title = $"{leftPlayer.Score} : {rightPlayer.Score}";
        }
        static void Init()
        {
            
            var racket1 = new Racket(2, height / 2, height);
            var racket2 = new Racket(width - 2, height / 2, height);
            
            ball = new Ball(width / 2, height / 2);
            
            leftPlayer = new ControllerPeople(ConsoleKey.W, ConsoleKey.S, racket1);
            rightPlayer = new ControllerAI(ball, racket2);
        }
    }
}