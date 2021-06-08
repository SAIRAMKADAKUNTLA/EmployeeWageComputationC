using System;
using System.Collections.Generic;
using System.Text;

namespace Empwage
{
    /// <summary>
    /// Totalwage for a each company
    /// </summary>
    public class Empwage
    {
        const int Is_Parttime = 1;
        const int Is_Fulltime = 2;
        private string Company;
        private int WagePerHr;
        private int WorkingDays;
        private int WorkingHrs;
        private int TotalWage;
        public Empwage(string Company, int WagePerHour, int WorkingDays, int WorkingHrs)
        {
            this.Company = Company;
            this.WagePerHr = WagePerHr;
            this.WorkingDays = WorkingDays;
            this.WorkingHrs = WorkingHrs;

        }

        public void ComputeTotalEmpwage(string company, int WageperHr, int WorkingDays, int WorkingHrs)
        {


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
            Console.WriteLine("TotalWage of the company is :" + Company + "=" + TotalWage);
      
        }

        public string tostring()
        {
            return "Total Employee Wage for Company : " + this.Company + "is:" + TotalWage;


        }
    }
}

