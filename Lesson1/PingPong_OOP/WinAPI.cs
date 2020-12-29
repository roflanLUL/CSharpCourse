using System;
using System.Runtime.InteropServices;

namespace PingPong_OOP
{
    static class WinAPI
    {
        [DllImport("user32.dll")]
        static extern ushort GetAsyncKeyState(int vKey);

        public static bool IsKeyDown(ConsoleKey vKey)
        {
            return 0 != (GetAsyncKeyState((int) vKey) & 0x8000);
        }
    }
}