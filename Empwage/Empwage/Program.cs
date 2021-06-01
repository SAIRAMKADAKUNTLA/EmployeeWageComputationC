using System;

namespace Empwage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation");
            Empwage empwage = new Empwage();
            empwage.Attendance();
            empwage.DailyWage();
            empwage.ParttimeWage();
        }
    }
}
