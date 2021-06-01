using System;
using System.Collections.Generic;
using System.Text;

namespace Empwage
{
    public class Empwage
    {
        const int Is_Present = 1;
        public void Attendance()
        {
            //UC1-Attendance
            Random random = new Random();
            int Empcheck = random.Next(0, 2);
            if (Empcheck == Is_Present)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }

        //UC2-DailyWage

        const int Is_Fulltime = 1;
        int WageperHr = 20;
        int FulldayHr = 8;
        public void DailyWage()
        {
            Random random = new Random();
            int Empcheck = random.Next(0, 2);
            if (Empcheck == Is_Fulltime)
                Console.WriteLine("DailyWage for the Employee:" + WageperHr * FulldayHr);
            else
                Console.WriteLine("DailyWage for the Employee:0");
        }
        //UC3-ParttimeWage
        const int Is_Parttime = 1;
        
        int ParttimeHr = 4;
        int FulltimeHr = 8;


        public void ParttimeWage()
        {
            Random random = new Random();
            int Empcheck = random.Next(0, 3);
            if (Empcheck == Is_Parttime)
                Console.WriteLine("ParttimeWage:" + ParttimeHr * WageperHr);
            else if (Empcheck == Is_Fulltime)
                Console.WriteLine("FulltimeWage:" + FulltimeHr * WageperHr);
            else
                Console.WriteLine("EmpWage:0");

        }
    }

}
