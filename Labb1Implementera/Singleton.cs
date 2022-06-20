using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera
{
    public sealed class Singleton
    {
        private static Singleton instance = null;

        private Singleton()
        {

        }

        private static object syncLock = new Object();
        public static Singleton Instance
        {
            get 
            {
                lock (syncLock)
                {
                    if (Singleton.instance == null) Singleton.instance = new Singleton();
                    return Singleton.instance;
                }
            }
        }

        public void ErrorMessage()
        {
            Console.WriteLine("Invalid input");
        }
    }
}
