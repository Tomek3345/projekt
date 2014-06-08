using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is hello world...
            Console.WriteLine("Hello world !");
            Console.ReadKey();
            Console.Write("What's your name ? ");
            Console.WriteLine("Hello " + Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("Bye bye...");
        }
    }
}
