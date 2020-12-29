using System;

namespace PingPong_OOP
{
    class ControllerPeople : Controller
    {
        private ConsoleKey upKey;
        private ConsoleKey downKey;
        
        public ControllerPeople(ConsoleKey up, ConsoleKey down, Racket racket)
        {
            this.racket = racket;
            
            upKey = up;
            downKey = down;
        }

        public override void Controll()
        {
            if (WinAPI.IsKeyDown(upKey)) racket.Shift--;
            if (WinAPI.IsKeyDown(downKey)) racket.Shift++;
        }
    }
}