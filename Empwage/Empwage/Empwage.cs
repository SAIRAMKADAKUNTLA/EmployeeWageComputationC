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
            Random random = new Random();
            int Empcheck = random.Next(0, 2);
            if (Empcheck == Is_Present)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
