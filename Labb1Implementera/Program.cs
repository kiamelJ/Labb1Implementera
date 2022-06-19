using System;

namespace Labb1Implementera
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Handler.MainMenu();
            }
        }
    }
}
