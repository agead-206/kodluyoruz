﻿using System;

namespace dotnet_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi there!");
            Console.WriteLine(" Please enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your surname ");
            string surename = Console.ReadLine();
            Console.WriteLine("Welcome " + name + " "+ surename +".");
        }
    }
}
