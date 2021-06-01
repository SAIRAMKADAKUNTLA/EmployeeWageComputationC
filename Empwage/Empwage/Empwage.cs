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

    }
}
