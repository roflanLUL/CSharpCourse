using System;

namespace PingPong_OOP
{
    class ControllerAI : Controller
    {
        private Ball ball;
        
        public ControllerAI(Ball ball, Racket racket)
        {
            this.racket = racket;
            this.ball = ball;
        }
        
        public override void Controll()
        {
            if (ball.Y < racket.Y) racket.Shift--;
            if (ball.Y < racket.Y) racket.Shift++;
        }
    }
}