using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for input
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            string name = input;
            //run printName Method
            PrintName(name);

        }
        private static void PrintName(string name)
        {
            Console.WriteLine("Hello"+" "+name);
        }
    }
}
