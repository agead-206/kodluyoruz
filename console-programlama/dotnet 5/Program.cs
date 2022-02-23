using System;

namespace dotnet_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("enter your surname ");
            string surename = Console.ReadLine();
            Console.WriteLine("Hi " + name + " "+ surename);
        }
    }
}
