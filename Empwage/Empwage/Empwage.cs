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
        //UC4-SwitchCase
        public void SwitchCase()
        {
            const int Is_Parttime = 1;
            const int Is_Fulltime = 2;
            int EmpWage = 0;
            int EmpHrs = 0;
            Random random = new Random();
            int Empcheck = random.Next(0, 3);
            switch (Empcheck)
            {
                case Is_Parttime:
                    EmpHrs = 4;
                    break;
                case Is_Fulltime:
                    EmpHrs = 8;
                    break;
                default:
                    EmpHrs = 0;
                    break;
            }
            EmpWage = EmpHrs * WageperHr;
            Console.WriteLine("Employee wage:" + EmpWage);
        }
        //UC5-MonthlyWage

        const int WorkingDays = 20;

        public void MonthlyWage()
        {
            const int Is_Parttime = 1;
            const int Is_Fulltime = 2;
            int EmpWage = 0;
            int EmpHrs = 0;
            int TotalWage = 0;
            for (int day = 0; day <= WorkingDays; day++)
            {
                Random random = new Random();
                int Empcheck = random.Next(0, 3);
                switch (Empcheck)
                {
                    case Is_Parttime:
                        EmpHrs = 4;
                        break;
                    case Is_Fulltime:
                        EmpHrs = 8;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }
                EmpWage = EmpHrs * WageperHr;
                TotalWage += EmpWage;
                Console.WriteLine("EmpWage:" + EmpWage);
            }
            Console.WriteLine("TotalWage:" + TotalWage);
        }
        //UC6-TotalWage

        const int WorkingHrs = 100;
        public void TotalWage()
        {
            const int Is_Parttime = 1;
            const int Is_Fulltime = 2;
            int TotalHrs = 0;
            int EmpHrs = 0;
            int TotalDays = 0;
            while (TotalHrs <= WorkingHrs && TotalDays <= WorkingDays)
            {
                TotalDays++;
                Random random = new Random();
                int Empcheck = random.Next(0, 3);
                switch (Empcheck)
                {
                    case Is_Parttime:
                        EmpHrs = 4;
                        break;
                    case Is_Fulltime:
                        EmpHrs = 8;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }

                TotalHrs += EmpHrs;
                Console.WriteLine("Days" + TotalDays + "EmpHrs" + EmpHrs);
            }
            int TotalWage = TotalHrs * WageperHr;
            Console.WriteLine("TotalWage:" + TotalWage);
        }
    }

}
