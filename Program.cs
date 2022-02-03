using System;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Tell me your name");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Goodbye!");
        }
    }
}
