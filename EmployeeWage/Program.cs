using System;

namespace EmployeeWage
{
    public class EmpWageBuilderObject
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
         
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays,int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            
        }     

        public void computeEmpWage()
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;

            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
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
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs" + empHrs);

            }

            int totalEmpWage = totalEmpHrs * this.empRatePerHour;
            this.totalEmpWage = totalEmpWage;
            //Console.WriteLine("\nTotal Employee wage for company  " + company + "  is "+ totalEmpWage);

        }
        public string toString()
        {
            return "Total Employee Wage for company : " + this.company + " is " + this.totalEmpWage;

        }
        public static void Main(string[] args)
        {
            EmpWageBuilderObject infosys = new EmpWageBuilderObject("Infosys", 30, 5, 60);
            EmpWageBuilderObject tcs = new EmpWageBuilderObject("TCS", 25, 6, 70);
            infosys.computeEmpWage();
            Console.WriteLine(infosys.toString());
            tcs.computeEmpWage();
            Console.WriteLine(tcs.toString());

        }
    }
}