using System;

namespace EmployeeWage01
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
       

        public static int computeEmpWage(string company,int empRatePerHour,int numOfWorkingDays,int maxHourPerMonth)
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;

            while (totalEmpHrs <= maxHourPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 4;
                        break;
                    case IS_PART_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                //Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs" + empHrs);

            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("\nTotal Employee wage for company  " + company + "  is "+ totalEmpWage);
            return totalEmpWage;
        }
        public static void Main(string[] args)
        {
            computeEmpWage("Infosys",30,5,60);
            computeEmpWage("TCS", 25, 6, 70);
            computeEmpWage("Accenture", 40, 8, 80);
        }
    }
}