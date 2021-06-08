using System;

namespace Empwage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation");
            Empwage More = new Empwage("More", 40, 5, 20);
            Empwage Heritage = new Empwage("Heritage", 30, 5, 10);
            More.ComputeTotalEmpwage("More", 40, 5, 20);
            Heritage.ComputeTotalEmpwage("Heritage", 30, 5, 10);

        }
    }
}
