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
            empwage.SwitchCase();
            empwage.MonthlyWage();
            empwage.TotalWage();
            empwage.ComputeEmpwage();
            empwage.ComputeTotalEmpwage("Heritage", 30, 5, 20);
            empwage.ComputeTotalEmpwage("More", 40, 6, 30);
        }
    }
}
