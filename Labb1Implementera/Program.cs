using System;

namespace Labb1Implementera
{
    class Program
    {
        //Jag har valt följande designmönster att implementera:
        // * Factory Method
        // * Singleton
        // * Strategy

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
