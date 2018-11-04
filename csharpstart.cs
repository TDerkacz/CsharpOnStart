using System;
using System.Collections.Generic;
using System.Linq;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            var names = new List<string> { "Ana", "Felipe", "Emillia" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");              
            }
            Console.ReadKey();
        }
    }
}