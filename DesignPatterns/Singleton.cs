using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public static class Singleton
    {
        private static readonly int Counter = 0;
        static Singleton()
        {
            Console.WriteLine(Counter++);
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
