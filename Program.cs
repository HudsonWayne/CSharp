// See https://aka.ms/new-console-template for more information
using System;

namespace MyCSharpApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine(); 
            Console.WriteLine($"Hello {name}");
        }
    }
}
